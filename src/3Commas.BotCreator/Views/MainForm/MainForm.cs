using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _3Commas.BotCreator.Misc;
using _3Commas.BotCreator.Services.BotSettingService;
using _3Commas.BotCreator.Services.MessageBoxService;
using AutoMapper;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly MainFormPresenter _presenter;

        public MainForm(IMessageBoxService mbs, IBotSettingService bss, IMapper mapper)
        {
            InitializeComponent();

            this.Text = $"{AssemblyHelper.AssemblyTitle} {AssemblyHelper.AssemblyVersion}";

            _presenter = new MainFormPresenter(this, new TextBoxLogger(txtOutput), mbs, bss, mapper);

            panelStopLoss.DataBindings.Add(nameof(Enabled), chkStopLossEnabled, nameof(CheckBox.Checked));
            lblStopLossTimeoutUnit.DataBindings.Add(nameof(Enabled), chkStopLossTimeoutEnabled, nameof(CheckBox.Checked));

            
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await _presenter.OnViewReady();
        }

        public void BindCombos()
        {
            ControlHelper.AddValuesToCombobox(cmbStrategy, Strategy.Long);
            ControlHelper.AddValuesToCombobox<StartOrderType>(cmbStartOrderType);
            ControlHelper.AddValuesToCombobox<StopLossType>(cmbStopLossType);
            ControlHelper.AddValuesToCombobox<LeverageType>(cmbLeverageType);
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            await _presenter.OnCreate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _presenter.OnClearClick();
        }

        private void txtQuoteCurrency_TextChanged(object sender, EventArgs e)
        {
            _presenter.OnQuoteCurrencyChanged();
        }

        private void cmbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStrategy.DataBindings.Count > 0) cmbStrategy.DataBindings[0].WriteValue();
            _presenter.OnStrategyChanged();
        }

        private void chkTrailing_CheckedChanged(object sender, EventArgs e)
        {
            lblTrailing.Enabled = chkTrailing.Checked;
            numTrailingDeviation.Enabled = chkTrailing.Checked;
            lblTrailingUnit.Enabled = chkTrailing.Checked;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            _presenter.OnAboutClicked();
        }

        private void btnAddStartCondition_Click(object sender, EventArgs e)
        {
            _presenter.OnAddStartConditionClicked();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _presenter.OnRemoveStartCondition();
        }

        private void txtBotname_TextChanged(object sender, EventArgs e)
        {
            if (txtBotname.DataBindings.Count > 0) txtBotname.DataBindings[0].WriteValue();
            _presenter.OnBotNameChanged();
        }

        private async void linkLabel3Commas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            await _presenter.On3CommasLinkClicked();
        }

        private void linkLabelBinance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.OnBinanceLinkClicked();
        }

        private void linkLabelHuobi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _presenter.OnHuobiLinkClicked();
        }

        private void chkBuyBase_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.OnBuyBaseChanged(chkBuyBase.Checked);
        }

        public List<BotStrategy> SelectedStartConditions => listViewStartConditions.SelectedItems.Cast<ListViewItem>().Select(selectedItem => (BotStrategy)selectedItem.Tag).ToList();
        public BotSettings SelectedTemplate => (BotSettings)cmbTemplates.SelectedItem;
        public bool UsePaperTrading => chkUsePaperTrading.Checked;
        public bool IsBinanceSelected => rbBinance.Checked;
        public bool IsHuobiSelected => rbHuobi.Checked;
        public int StartConditionsCount => listViewStartConditions.Items.Count;
        public int NumberOfBotsToCreate => (int)numAmount.Value;
        public bool Enable => chkEnable.Checked;

        public void SetNamePreview(string name)
        {
            lblBotNamePreview.Text = name;
        }

        public void BindAccountsAndSetSelection(List<Account> accounts, int? selectedAccount)
        {
            cmbExchange.DataSource = accounts;
            cmbExchange.ValueMember = nameof(Account.Id);
            cmbExchange.DisplayMember = nameof(Account.Name);
            cmbExchange.SelectedItem = selectedAccount;
        }

        public void ClearLog()
        {
            txtOutput.Clear();
        }

        public void RefreshQuoteCurrencyLabel(string text)
        {
            lblQuoteCurrency.Text = text;
            lblQuoteCurrency.Visible = true;
        }

        public void SetControlStateToBuyBaseCurrency(bool isEnabled)
        {
            lblBuyTitle.Enabled = isEnabled;
            lblQuoteCurrency.Enabled = isEnabled;
            numAmountToBuy.Enabled = isEnabled;
        }

        public void SetCreateInProgress(bool inProgress)
        {
            panelMain.Enabled = !inProgress;
            groupBoxSettings.Enabled = !inProgress;
            groupBoxCredentials.Enabled = !inProgress;
            progressBar.Visible = inProgress;
            btnCancel.Text = "Cancel";
            btnCancel.Enabled = inProgress;
            btnCancel.Visible = inProgress;
        }

        public void RefreshStartConditions(List<BotStrategy> startConditions)
        {
            listViewStartConditions.Clear();
            foreach (var startCondition in startConditions)
            {
                listViewStartConditions.Items.Add(new ListViewItem { Tag = startCondition, Text = startCondition.Name, Name = startCondition.GetHashCode().ToString() });
            }
        }

        public void RefreshTemplateCombo(List<BotSettings> templates, bool selectFirst)
        {
            cmbTemplates.SelectedIndexChanged -= cmbTemplates_SelectedIndexChanged;
            cmbTemplates.DataSource = templates;
            cmbTemplates.ValueMember = nameof(BotSettings.Id);
            cmbTemplates.DisplayMember = nameof(BotSettings.Name);
            cmbTemplates.SelectedIndex = selectFirst && templates.Any() ? 0 : -1;
            btnDeleteTemplate.Enabled = selectFirst;
            cmbTemplates.SelectedIndexChanged += cmbTemplates_SelectedIndexChanged;
        }

        public void BindSetting(BotSettingViewModel botSetting)
        {
            // Accounts will not be bound due to lack of nullable support
            if (botSetting.ExchangeAccountId.HasValue && cmbExchange.Items.Count > 0)
            {
                cmbExchange.SelectedItem = cmbExchange.Items.Cast<Account>().Single(x => x.Id == botSetting.ExchangeAccountId);
            }
            else
            {
                cmbExchange.SelectedItem = null;
            }

            // Deal Start Conditions will not be bound
            RefreshStartConditions(botSetting.DealStartConditions);

            #region Regular DataBinding by code

            chkCheckForExistingBots.DataBindings.Clear();
            chkCheckForExistingBots.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.SkipExistingPairs));

            chkSkipBlacklistedPairs.DataBindings.Clear();
            chkSkipBlacklistedPairs.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.SkipBlacklistedPairs));

            chkCheckForBaseStablecoin.DataBindings.Clear();
            chkCheckForBaseStablecoin.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.SkipBaseStablecoin));

            txtQuoteCurrency.DataBindings.Clear();
            txtQuoteCurrency.DataBindings.Add(nameof(TextBox.Text), botSetting, nameof(BotSettingViewModel.QuoteCurrency));

            cmbStrategy.SelectedIndexChanged -= cmbStrategy_SelectedIndexChanged;
            cmbStrategy.DataBindings.Clear();
            cmbStrategy.DataBindings.Add(nameof(ComboBox.SelectedItem), botSetting, nameof(BotSettingViewModel.Strategy), false, DataSourceUpdateMode.OnPropertyChanged);
            cmbStrategy.SelectedIndexChanged += cmbStrategy_SelectedIndexChanged;

            txtBotname.DataBindings.Clear();
            txtBotname.DataBindings.Add(nameof(TextBox.Text), botSetting, nameof(BotSettingViewModel.Botname), true, DataSourceUpdateMode.OnPropertyChanged);

            cmbStartOrderType.DataBindings.Clear();
            cmbStartOrderType.DataBindings.Add(nameof(ComboBox.SelectedItem), botSetting, nameof(BotSettingViewModel.StartOrderType));

            numBaseOrderVolume.DataBindings.Clear();
            numBaseOrderVolume.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.BaseOrderSize), false, DataSourceUpdateMode.OnPropertyChanged);

            numSafetyOrderVolume.DataBindings.Clear();
            numSafetyOrderVolume.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.SafetyOrderSize), false, DataSourceUpdateMode.OnPropertyChanged);

            numTargetProfit.DataBindings.Clear();
            numTargetProfit.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.TargetProfit), false, DataSourceUpdateMode.OnPropertyChanged);

            chkTrailing.DataBindings.Clear();
            chkTrailing.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.TrailingEnabled));

            numTrailingDeviation.DataBindings.Clear();
            numTrailingDeviation.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.TrailingDeviation), false, DataSourceUpdateMode.OnPropertyChanged);

            numMaxSafetyTradesCount.DataBindings.Clear();
            numMaxSafetyTradesCount.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.MaxSafetyTradesCount), false, DataSourceUpdateMode.OnPropertyChanged);

            numMaxActiveSafetyTradesCount.DataBindings.Clear();
            numMaxActiveSafetyTradesCount.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.MaxActiveSafetyTradesCount), false, DataSourceUpdateMode.OnPropertyChanged);

            numPriceDeviationToOpenSafetyOrders.DataBindings.Clear();
            numPriceDeviationToOpenSafetyOrders.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.PriceDeviationToOpenSafetyOrders), false, DataSourceUpdateMode.OnPropertyChanged);

            numSafetyOrderVolumeScale.DataBindings.Clear();
            numSafetyOrderVolumeScale.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.SafetyOrderVolumeScale), false, DataSourceUpdateMode.OnPropertyChanged);

            numSafetyOrderStepScale.DataBindings.Clear();
            numSafetyOrderStepScale.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.SafetyOrderStepScale), false, DataSourceUpdateMode.OnPropertyChanged);

            numCooldownBetweenDeals.DataBindings.Clear();
            numCooldownBetweenDeals.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.CooldownBetweenDeals), false, DataSourceUpdateMode.OnPropertyChanged);

            chkBuyBase.DataBindings.Clear();
            chkBuyBase.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.BuyBaseCurrency));

            numAmountToBuy.DataBindings.Clear();
            numAmountToBuy.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.BaseCurrencyToBuy), false, DataSourceUpdateMode.OnPropertyChanged);

            chkStopLossEnabled.DataBindings.Clear();
            chkStopLossEnabled.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.StopLossEnabled));

            numStopLossPercentage.DataBindings.Clear();
            numStopLossPercentage.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.StopLossPercentage), false, DataSourceUpdateMode.OnPropertyChanged);

            cmbStopLossType.DataBindings.Clear();
            cmbStopLossType.DataBindings.Add(nameof(ComboBox.SelectedItem), botSetting, nameof(BotSettingViewModel.StopLossAction));

            chkStopLossTimeoutEnabled.DataBindings.Clear();
            chkStopLossTimeoutEnabled.DataBindings.Add(nameof(CheckBox.Checked), botSetting, nameof(BotSettingViewModel.StopLossTimeoutEnabled));

            numStopLossTimeout.DataBindings.Clear();
            numStopLossTimeout.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.StopLossTimeout), false, DataSourceUpdateMode.OnPropertyChanged);

            cmbLeverageType.DataBindings.Clear();
            cmbLeverageType.DataBindings.Add(nameof(ComboBox.SelectedItem), botSetting, nameof(BotSettingViewModel.LeverageType));

            numCustomLeverageValue.DataBindings.Clear();
            numCustomLeverageValue.DataBindings.Add(nameof(NumericUpDown.Value), botSetting, nameof(BotSettingViewModel.LeverageCustomValue), false, DataSourceUpdateMode.OnPropertyChanged);

            #endregion
        }

        private void cmbTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTemplate = cmbTemplates.SelectedItem as BotSettings;
            btnDeleteTemplate.Enabled = selectedTemplate != null;
            _presenter.OnTemplateChange(selectedTemplate);
        }

        private void cmbExchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            _presenter.OnAccountChanged(cmbExchange.SelectedItem as Account);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _presenter.OnSave();
        }

        private void btnDeleteTemplate_Click(object sender, EventArgs e)
        {
            _presenter.OnDeleteTemplate();
        }

        private void chkStopLossTimeoutEnabled_CheckedChanged(object sender, EventArgs e)
        {
            numStopLossTimeout.Enabled = chkStopLossTimeoutEnabled.Checked;
        }

        private void cmbLeverageType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isLeverageNotSpecified = (LeverageType)cmbLeverageType.SelectedItem == LeverageType.NotSpecified;
            lblLeverageCustomValue.Enabled = !isLeverageNotSpecified;
            numCustomLeverageValue.Enabled = !isLeverageNotSpecified;
        }

        private async void btnPreview_Click(object sender, EventArgs e)
        {
            await _presenter.OnPreview();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnCancel.Text = "Cancelled!";
            _presenter.OnCancelOperation();
        }
    }
}
