using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3Commas.BotCreator.Infrastructure;
using _3Commas.BotCreator.Logic.ExchangeImplementations;
using _3Commas.BotCreator.Logic.Misc;
using Microsoft.Extensions.Logging;
using XCommas.Net.Objects;
using Keys = _3Commas.BotCreator.Logic.Keys;

namespace _3Commas.BotCreator.Views
{
    public class MainFormPresenter : PresenterBase<IMainForm>
    {
        private readonly Keys _keys = new Keys();
        private readonly ILogger _logger;
        private readonly IMessageBoxService _mbs;
        private List<Account> _accounts = new List<Account>();
        private readonly List<BotStrategy> _startConditions = new List<BotStrategy>();

        public MainFormPresenter(IMainForm view, ILogger logger, IMessageBoxService mbs) : base(view)
        {
            _logger = logger;
            _mbs = mbs;
            _keys.ApiKey3Commas = Properties.Settings.Default.ApiKey3Commas;
            _keys.Secret3Commas = Properties.Settings.Default.Secret3Commas;
            _keys.ApiKeyBinance = Properties.Settings.Default.ApiKeyBinance;
            _keys.SecretBinance = Properties.Settings.Default.SecretBinance;
            _keys.ApiKeyHuobi = Properties.Settings.Default.ApiKeyHuobi;
            _keys.SecretHuobi = Properties.Settings.Default.SecretHuobi;
        }

        internal void OnViewReady()
        {
            View.BindCombos();
            RefreshNamePreview();
        }

        public void OnBotNameChanged()
        {
            RefreshNamePreview();
        }

        public void RefreshNamePreview()
        {
            var quoteCurrency = (!String.IsNullOrWhiteSpace(View.QuoteCurrency)) ? View.QuoteCurrency + "_XXX" : "";
            var strategy = View.SelectedStrategy;

            var namePreview = Logic.Misc.Logic.GenerateBotName(View.Botname, quoteCurrency, strategy);
            View.SetNamePreview(namePreview);
        }

        public void OnHuobiLinkClicked()
        {
            var settingsPersisted = !string.IsNullOrWhiteSpace(Properties.Settings.Default.ApiKeyHuobi);
            var settings = new Settings(settingsPersisted, "Huobi API Credentials", "Permissions Needed: Read-Only, Trade", _keys.ApiKeyHuobi, _keys.SecretHuobi);
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
            var settings = new Settings(settingsPersisted, "Binance API Credentials", "Permissions Needed: Can Read, Enable Spot Trading", _keys.ApiKeyBinance, _keys.SecretBinance);
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
            var settings = new Settings(settingsPersisted, "3Commas API Credentials", "Permissions Needed: BotsRead, BotsWrite, AccountsRead", _keys.ApiKey3Commas, _keys.Secret3Commas);
            var dr = settings.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _keys.ApiKey3Commas = settings.ApiKey;
                _keys.Secret3Commas = settings.Secret;
                
                Properties.Settings.Default.ApiKey3Commas = settings.PersistKeys ? settings.ApiKey : "";
                Properties.Settings.Default.Secret3Commas = settings.PersistKeys ? settings.Secret : "";
                Properties.Settings.Default.Save();

                await RefreshExchanges();
            }
        }

        private async Task RefreshExchanges()
        {
            if (!String.IsNullOrWhiteSpace(_keys.Secret3Commas) && !String.IsNullOrWhiteSpace(_keys.ApiKey3Commas))
            {
                var selection = View.Account;
                var botMgr = new BotManager(_keys, _logger);
                _accounts = await botMgr.RetrieveAccounts();

                View.BindAccountsAndSetSelection(_accounts, selection);
            }
            else
            {
                View.BindAccountsAndSetSelection(null, null);
            }
        }

        public bool IsValid()
        {
            var errors = new List<string>();
            if (_accounts.Count == 0)
            {
                errors.Add("Please specify 3Commas API Credentials and select your 3Commas Exchange Account.");
            }
            else if (View.Account == null)
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

            if (string.IsNullOrWhiteSpace(View.Botname)) errors.Add("Bot name missing");
            if (string.IsNullOrWhiteSpace(View.QuoteCurrency)) errors.Add("Quote Currency missing");
            if (View.StartConditionsCount == 0) errors.Add("Deal Start Condition missing");
            if (View.SelectedStrategy == null || !Strategy.TryParse(View.SelectedStrategy, out Strategy _)) errors.Add("Strategy not selected");
            if (View.StartOrderType == null || !StartOrderType.TryParse(View.StartOrderType, out StartOrderType _)) errors.Add("Start Order Type not selected");
            if (errors.Any())
            {
                _mbs.ShowError(String.Join(Environment.NewLine, errors), "Validation Error");
            }

            return !errors.Any();
        }

        public void OnClearClick()
        {
            View.ClearLog();
        }

        public void OnQuoteCurrencyChanged()
        {
            View.RefreshQuoteCurrencyLabel(View.QuoteCurrency);
            RefreshNamePreview();
        }

        public void OnBuyBaseChanged(bool isBuyEnabled)
        {
            View.SetControlStateToBuyBaseCurrency(isBuyEnabled);
        }

        public void OnAddStartConditionClicked()
        {
            ChooseSignal form = new ChooseSignal();
            var dr = form.ShowDialog(this.View);
            if (dr == DialogResult.OK)
            {
                _startConditions.Add(form.Strategy);
                View.RefreshStartConditions(_startConditions);
            }
        }

        public void OnRemoveStartConditionClicked()
        {
            foreach (string hash in View.SelectedStartConditions)
            {
                _startConditions.RemoveAll(x => x.GetHashCode().ToString() == hash);
            }
            View.RefreshStartConditions(_startConditions);
        }

        public async Task OnCreateClicked()
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
                        exchange = new Logic.ExchangeImplementations.Binance.Binance(_keys);
                    }
                    else if (View.IsHuobiSelected)
                    {
                        exchange = new Logic.ExchangeImplementations.Huobi.Huobi(_keys);
                    }

                    BotManager botMgr = new BotManager(_keys, _logger);

                    Strategy.TryParse(View.SelectedStrategy, out Strategy strategy);
                    Strategy.TryParse(View.StartOrderType, out StartOrderType startOrderType);
                    
                    decimal amountToBuy = 0;
                    if (View.IsBuyEnabled)
                    {
                        amountToBuy = View.AmountToBuy;
                    }

                    try
                    {
                        await botMgr.CreateBots(View.CheckForExistingBots, View.NumberOfBotsToCreate, View.QuoteCurrency, strategy, startOrderType, View.MaxSafetyTradesCount, View.MaxActiveSafetyTradesCount, View.PriceDeviationToOpenSafetyOrders, View.SafetyOrderVolumeScale, View.SafetyOrderStepScale, View.TargetProfitPercentage, View.IsTrailingEnabled, View.TrailingDeviation, View.Botname, View.BaseOrderVolume, View.SafetyOrderVolume, View.EnableBots, _startConditions, View.CooldownBetweenDeals, exchange, View.Account.Id, amountToBuy);
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
    }
}
