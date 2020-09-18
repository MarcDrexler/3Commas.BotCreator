using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using _3Commas.BotCreator.Infrastructure;
using _3Commas.BotCreator.Misc;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly MainFormPresenter _presenter;

        public MainForm()
        {
            InitializeComponent();
            _presenter = new MainFormPresenter(this, new TextBoxLogger(txtOutput), new MessageBoxService());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _presenter.OnViewReady();
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
            _presenter.RefreshNamePreview();
        }

        private void chkTrailing_CheckedChanged(object sender, EventArgs e)
        {
            lblTrailing.Enabled = chkTrailing.Checked;
            numTrailingDeviation.Enabled = chkTrailing.Checked;
            lblTrailingUnit.Enabled = chkTrailing.Checked;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox.AboutBox box = new AboutBox.AboutBox();
            box.ShowDialog(this);
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

        public void BindCombos()
        {
            ControlHelper.AddValuesToCombobox(cmbStrategy, Strategy.Long);
            ControlHelper.AddValuesToCombobox<StartOrderType>(cmbStartOrderType);
        }

        public string QuoteCurrency => txtQuoteCurrency.Text;

        public string Botname => txtBotname.Text;
        public Account Account => cmbExchange.SelectedItem as Account;
        public List<string> SelectedStartConditions => listViewStartConditions.SelectedItems.Cast<ListViewItem>().Select(selectedItem => selectedItem.Name).ToList();
        public string SelectedStrategy => cmbStrategy.SelectedItem?.ToString();
        public bool IsBinanceSelected => rbBinance.Checked;
        public bool IsHuobiSelected => rbHuobi.Checked;
        public string StartOrderType => cmbStartOrderType.SelectedItem?.ToString();
        public int StartConditionsCount => listViewStartConditions.Items.Count;
        public int NumberOfBotsToCreate => (int)numAmount.Value;
        public int CooldownBetweenDeals => (int) numCooldownBetweenDeals.Value;
        public bool EnableBots => chkEnable.Checked;
        public decimal SafetyOrderVolume => numSafetyOrderVolume.Value;
        public decimal BaseOrderVolume => numBaseOrderVolume.Value;
        public decimal TrailingDeviation => numTrailingDeviation.Value;
        public bool IsTrailingEnabled => chkTrailing.Checked;
        public decimal TargetProfitPercentage => numTargetProfit.Value;
        public decimal SafetyOrderStepScale => numSafetyOrderStepScale.Value;
        public decimal SafetyOrderVolumeScale => numSafetyOrderVolumeScale.Value;
        public decimal PriceDeviationToOpenSafetyOrders => numPriceDeviationToOpenSafetyOrders.Value;
        public int MaxActiveSafetyTradesCount => (int) numMaxActiveSafetyTradesCount.Value;
        public int MaxSafetyTradesCount => (int) numMaxSafetyTradesCount.Value;
        public bool IsBuyEnabled => chkBuyBase.Checked;
        public decimal AmountToBuy => numAmountToBuy.Value;
        public bool CheckForExistingBots => chkCheckForExistingBots.Checked;

        public void SetNamePreview(string name)
        {
            lblBotNamePreview.Text = name;
        }

        public void BindAccountsAndSetSelection(List<Account> accounts, Account selectedAccount)
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
            panelBotSettings.Enabled = !inProgress;
            groupBoxCredentials.Enabled = !inProgress;
        }

        public void RefreshStartConditions(List<BotStrategy> startConditions)
        {
            listViewStartConditions.Clear();

            foreach (var startCondition in startConditions)
            {
                listViewStartConditions.Items.Add(new ListViewItem() { Tag = startCondition, Text = startCondition.Name, Name = startCondition.GetHashCode().ToString() });
            }
        }
    }
}
