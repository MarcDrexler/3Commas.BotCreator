using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Commas.BotCreator._3CommasLayer.Implementations;
using _3Commas.BotCreator.ExchangeLayer;
using _3Commas.BotCreator.Infrastructure;
using _3Commas.BotCreator.Misc;
using _3Commas.BotCreator.Services.BotSettingService;
using _3Commas.BotCreator.Services.MessageBoxService;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public class MainFormPresenter : PresenterBase<IMainForm>
    {
        private readonly Keys _keys = new Keys();
        private readonly ILogger _logger;
        private readonly IMessageBoxService _mbs;
        private readonly IBotSettingService _bss;
        private readonly IMapper _mapper;
        private List<Account> _accounts = new List<Account>();
        private BotSettingViewModel _settings = new BotSettingViewModel();

        public MainFormPresenter(IMainForm view, ILogger logger, IMessageBoxService mbs, IBotSettingService bss, IMapper mapper) : base(view)
        {
            _logger = logger;
            _mbs = mbs;
            _bss = bss;
            _mapper = mapper;
            _keys.ApiKey3Commas = Properties.Settings.Default.ApiKey3Commas;
            _keys.Secret3Commas = Properties.Settings.Default.Secret3Commas;
            _keys.ApiKeyBinance = Properties.Settings.Default.ApiKeyBinance;
            _keys.SecretBinance = Properties.Settings.Default.SecretBinance;
            _keys.ApiKeyHuobi = Properties.Settings.Default.ApiKeyHuobi;
            _keys.SecretHuobi = Properties.Settings.Default.SecretHuobi;
        }

        internal async Task OnViewReady()
        {
            View.BindCombos();
            await RefreshExchangesAndBlacklist();
            RefreshTemplates(false);
            View.BindSetting(_settings);
            RefreshNamePreview();
        }

        private void RefreshTemplates(bool selectFirst)
        {
            var templates = _bss.GetAll();
            View.RefreshTemplateCombo(templates, selectFirst);
        }

        public void OnBotNameChanged()
        {
            RefreshNamePreview();
        }

        private void RefreshNamePreview()
        {
            var quoteCurrency = (!String.IsNullOrWhiteSpace(_settings.QuoteCurrency)) ? _settings.QuoteCurrency + "_XXX" : "";
            var strategy = _settings.Strategy;

            var namePreview = NameHelper.GenerateBotName(_settings.Botname, quoteCurrency, strategy);
            View.SetNamePreview(namePreview);
        }

        public void OnHuobiLinkClicked()
        {
            var settingsPersisted = !string.IsNullOrWhiteSpace(Properties.Settings.Default.ApiKeyHuobi);
            var settings = new SetApiKeyView.SetApiKeyView(settingsPersisted, "Huobi API Credentials", "Permissions Needed: Read-Only, Trade", _keys.ApiKeyHuobi, _keys.SecretHuobi);
            var dr = settings.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _keys.ApiKeyHuobi = settings.ApiKey;
                _keys.SecretHuobi = settings.Secret;

                Properties.Settings.Default.ApiKeyHuobi = settings.PersistKeys ? settings.ApiKey : "";
                Properties.Settings.Default.SecretHuobi = settings.PersistKeys ? settings.Secret : "";
                Properties.Settings.Default.Save();
            }
        }

        public void OnBinanceLinkClicked()
        {
            var settingsPersisted = !string.IsNullOrWhiteSpace(Properties.Settings.Default.ApiKeyBinance);
            var settings = new SetApiKeyView.SetApiKeyView(settingsPersisted, "Binance API Credentials", "Permissions Needed: Can Read, Enable Spot Trading", _keys.ApiKeyBinance, _keys.SecretBinance);
            var dr = settings.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _keys.ApiKeyBinance = settings.ApiKey;
                _keys.SecretBinance = settings.Secret;

                Properties.Settings.Default.ApiKeyBinance = settings.PersistKeys ? settings.ApiKey : "";
                Properties.Settings.Default.SecretBinance = settings.PersistKeys ? settings.Secret : "";
                Properties.Settings.Default.Save();
            }
        }

        public async Task On3CommasLinkClicked()
        {
            var settingsPersisted = !string.IsNullOrWhiteSpace(Properties.Settings.Default.ApiKey3Commas);
            var settings = new SetApiKeyView.SetApiKeyView(settingsPersisted, "3Commas API Credentials", "Permissions Needed: BotsRead, BotsWrite, AccountsRead", _keys.ApiKey3Commas, _keys.Secret3Commas);
            var dr = settings.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _keys.ApiKey3Commas = settings.ApiKey;
                _keys.Secret3Commas = settings.Secret;
                
                Properties.Settings.Default.ApiKey3Commas = settings.PersistKeys ? settings.ApiKey : "";
                Properties.Settings.Default.Secret3Commas = settings.PersistKeys ? settings.Secret : "";
                Properties.Settings.Default.Save();

                await RefreshExchangesAndBlacklist();
            }
        }

        private async Task RefreshExchangesAndBlacklist()
        {
            if (!String.IsNullOrWhiteSpace(_keys.Secret3Commas) && !String.IsNullOrWhiteSpace(_keys.ApiKey3Commas))
            {
                var selection = _settings.ExchangeAccountId;
                var botMgr = new BotManager(_logger, new XCommasClient(_keys), null);
                _accounts = await botMgr.RetrieveAccounts();
                View.BindAccountsAndSetSelection(_accounts, selection);
            }
            else
            {
                View.BindAccountsAndSetSelection(null, null);
            }
        }

        private bool IsValid()
        {
            var errors = new List<string>();
            if (_accounts.Count == 0)
            {
                errors.Add("Please specify 3Commas API Credentials and select your 3Commas Exchange Account.");
            }
            else if (_settings.ExchangeAccountId == null)
            {
                errors.Add("3Commas Exchange Account not selected.");
            }

            if (!View.IsBinanceSelected && !View.IsHuobiSelected)
            {
                errors.Add("Choose your preferred Exchange.");
            }

            if (View.IsBinanceSelected && (String.IsNullOrWhiteSpace(_keys.ApiKeyBinance) || String.IsNullOrWhiteSpace(_keys.SecretBinance)))
            {
                errors.Add("API Credentials for Binance missing");
            }

            if (View.IsHuobiSelected && (String.IsNullOrWhiteSpace(_keys.ApiKeyHuobi) || String.IsNullOrWhiteSpace(_keys.SecretHuobi)))
            {
                errors.Add("API Credentials for Huobi missing");
            }

            if (string.IsNullOrWhiteSpace(_settings.Botname)) errors.Add("Bot name missing");
            if (string.IsNullOrWhiteSpace(_settings.QuoteCurrency)) errors.Add("Quote Currency missing");
            if (View.StartConditionsCount == 0) errors.Add("Deal Start Condition missing");
            if (_settings.StopLossEnabled)
            {
                var maxDeviation = CalculateMaxSoDeviation();
                if (_settings.StopLossPercentage <= maxDeviation)
                {
                    errors.Add($"Stop Loss should be below the last safety order ({maxDeviation})");
                }
            }

            if (errors.Any())
            {
                _mbs.ShowError(String.Join(Environment.NewLine, errors), "Validation Error");
            }

            return !errors.Any();
        }

        private decimal CalculateMaxSoDeviation()
        {
            // todo
            return 0;
        }

        public void OnClearClick()
        {
            View.ClearLog();
        }

        public void OnQuoteCurrencyChanged()
        {
            View.RefreshQuoteCurrencyLabel(_settings.QuoteCurrency);
            RefreshNamePreview();
        }

        public void OnBuyBaseChanged(bool isBuyEnabled)
        {
            View.SetControlStateToBuyBaseCurrency(isBuyEnabled);
        }

        public void OnAddStartConditionClicked()
        {
            var frm = Program.ServiceProvider.GetRequiredService<ChooseSignalView.ChooseSignalView>();
            if (frm.ShowDialog(View) == DialogResult.OK)
            {
                _settings.DealStartConditions.Add(frm.Strategy);
                View.RefreshStartConditions(_settings.DealStartConditions);
            }
        }

        public void OnRemoveStartCondition()
        {
            foreach (var item in View.SelectedStartConditions)
            {
                _settings.DealStartConditions.Remove(item);
            }
            View.RefreshStartConditions(_settings.DealStartConditions);
        }

        public async Task OnCreate()
        {
            if (IsValid())
            {
                var dr = _mbs.ShowQuestion($"Do you really want to create {View.NumberOfBotsToCreate} Bots now?");
                if (dr == DialogResult.Yes)
                {
                    View.SetCreateInProgress(true);

                    IExchange exchange = null;
                    if (View.IsBinanceSelected)
                    {
                        exchange = new ExchangeLayer.Implementations.Binance(_keys);
                    }
                    else if (View.IsHuobiSelected)
                    {
                        exchange = new ExchangeLayer.Implementations.Huobi(_keys);
                    }

                    var botMgr = new BotManager(_logger, new XCommasClient(_keys), exchange);
                    
                    try
                    {
                        await botMgr.CreateBots(View.NumberOfBotsToCreate, View.Enable, _settings);
                        _mbs.ShowInformation("Bot creation finished! See output section for details.");
                    }
                    catch (Exception exception)
                    {
                        _logger.LogError(exception.Message);
                        _mbs.ShowError("Error: " + exception);
                    }
                    finally
                    {
                        View.SetCreateInProgress(false);
                    }
                }
            }
        }

        public void OnAccountChanged(Account cmbExchangeSelectedItem)
        {
            _settings.ExchangeAccountId = cmbExchangeSelectedItem?.Id;
        }

        public void OnSave()
        {
            var frm = Program.ServiceProvider.GetRequiredService<SaveTemplateView.SaveTemplateView>();
            frm.Init(_settings);
            var dr = frm.ShowDialog(View);
            if (dr == DialogResult.OK)
            {
                RefreshTemplates(true);
            }
        }

        public void OnTemplateChange(BotSettings botSettings)
        {
            _settings = botSettings == null ? new BotSettingViewModel() : _mapper.Map<BotSettings, BotSettingViewModel>(botSettings);

            View.BindSetting(_settings);
        }

        public void OnDeleteTemplate()
        {
            var dr = _mbs.ShowQuestion($"Do you really want to delete template '{View.SelectedTemplate.Name}' ?");
            if (dr == DialogResult.Yes)
            {
                _bss.Delete(View.SelectedTemplate.Id);
                RefreshTemplates(false);
            }
        }

        public void OnStrategyChanged()
        {
            RefreshNamePreview();

            _settings.DealStartConditions.Clear();
            View.RefreshStartConditions(_settings.DealStartConditions);
        }

        public void OnAboutClicked()
        {
            var frm = Program.ServiceProvider.GetRequiredService<AboutBox.AboutBox>();
            frm.ShowDialog(View);
        }
    }
}
