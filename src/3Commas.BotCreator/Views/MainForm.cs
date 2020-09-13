using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using _3Commas.BotCreator.Logic.Misc;
using _3Commas.BotCreator.Misc;
using Microsoft.Extensions.Logging;
using XCommas.Net.Objects;
using Binance = _3Commas.BotCreator.Logic.ExchangeImplementations.Binance.Binance;
using Keys = _3Commas.BotCreator.Logic.Keys;

namespace _3Commas.BotCreator.Views
{
    public partial class MainForm : Form
    {
        private readonly TextBoxLogger _logger;
        private readonly Keys _keys = new Keys();

        public MainForm()
        {
            InitializeComponent();
            _logger = new TextBoxLogger(txtOutput);

            _keys.ApiKey3Commas = ConfigurationManager.AppSettings["3CommasApiKey"];
            _keys.Secret3Commas = ConfigurationManager.AppSettings["3CommasSecret"];
            _keys.ApiKeyBinance = ConfigurationManager.AppSettings["BinanceApiKey"];
            _keys.SecretBinance = ConfigurationManager.AppSettings["BinanceSecret"];

            ControlHelper.AddValuesToCombobox<Strategy>(cmbStrategy, Strategy.Long);
            ControlHelper.AddValuesToCombobox<StartOrderType>(cmbStartOrderType);
            RefreshNamePreview();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var dr = MessageBox.Show($"Create {numAmount.Value} Bots now?", "Are you really sure? :-)", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    btnCreate.Enabled = false;
                    BotManager botMgr = new BotManager(_keys, _logger, new Logic.ExchangeImplementations.Binance.Binance(_keys));

                    Strategy.TryParse(cmbStrategy.SelectedItem.ToString(), out Strategy strategy);
                    Strategy.TryParse(cmbStartOrderType.SelectedItem.ToString(), out StartOrderType startOrderType);
                    var dealStartConditions = new List<BotStrategy>();
                    foreach (ListViewItem listViewItem in listViewStartConditions.Items)
                    {
                        dealStartConditions.Add((BotStrategy) listViewItem.Tag);
                    }

                    try
                    {
                        await botMgr.CreateBots((int)numAmount.Value, txtQuoteCurrency.Text, strategy, startOrderType, (int)numMaxSafetyTradesCount.Value, (int)numMaxActiveSafetyTradesCount.Value, numPriceDeviationToOpenSafetyOrders.Value, numSafetyOrderVolumeScale.Value, numSafetyOrderStepScale.Value, numTargetProfit.Value, chkTrailing.Checked, numTrailingDeviation.Value, txtBotname.Text, numBaseOrderVolume.Value, numSafetyOrderVolume.Value, chkEnable.Checked, dealStartConditions, (int)numCooldownBetweenDeals.Value, numAmountToBuy.Value);
                        MessageBox.Show("Finished.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exception)
                    {
                        _logger.LogError(exception.Message);
                        MessageBox.Show("Error: " + exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        btnCreate.Enabled = true;
                    }

                }
            }
        }

        private bool IsValid()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(_keys.Secret3Commas)) errors.Add("3Commas Secret missing");
            if (string.IsNullOrWhiteSpace(_keys.ApiKey3Commas)) errors.Add("3Commas API Key missing");
            if (string.IsNullOrWhiteSpace(_keys.SecretBinance)) errors.Add("Binance Secret missing");
            if (string.IsNullOrWhiteSpace(_keys.ApiKeyBinance)) errors.Add("Binance API Key missing");
            if (string.IsNullOrWhiteSpace(txtQuoteCurrency.Text)) errors.Add("Quote Currency missing");
            if (listViewStartConditions.Items.Count == 0) errors.Add("Deal Start Condition missing");

            if (cmbStrategy.SelectedItem == null || !Strategy.TryParse(cmbStrategy.SelectedItem.ToString(), out Strategy _)) errors.Add("Strategy not selected");
            if (cmbStartOrderType.SelectedItem == null || !StartOrderType.TryParse(cmbStartOrderType.SelectedItem.ToString(), out StartOrderType _)) errors.Add("Start Order Type not selected");
            if (errors.Any())
            {
                MessageBox.Show(String.Join(Environment.NewLine, errors), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return !errors.Any();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private void txtQuoteCurrency_TextChanged(object sender, EventArgs e)
        {
            lblQuoteCurrency.Text = txtQuoteCurrency.Text;
            lblQuoteCurrency.Visible = true;

            RefreshNamePreview();
        }
        
        private void cmbStrategy_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshNamePreview();
        }

        private void RefreshNamePreview()
        {
            var quoteCurrency = (!String.IsNullOrWhiteSpace(txtQuoteCurrency.Text)) ? txtQuoteCurrency.Text + "_XXX" : "";
            var strategy = cmbStrategy.SelectedItem?.ToString();

            lblBotNamePreview.Text = Logic.Misc.Logic.GenerateBotName(txtBotname.Text, quoteCurrency, strategy);
        }

        private void chkTrailing_CheckedChanged(object sender, EventArgs e)
        {
            lblTrailing.Visible = chkTrailing.Checked;
            numTrailingDeviation.Visible = chkTrailing.Checked;
            lblTrailingUnit.Visible = chkTrailing.Checked;
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings(_keys);
            settingsForm.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox();
            box.ShowDialog(this);
        }

        private void btnAddStartCondition_Click(object sender, EventArgs e)
        {
            ChooseSignal form = new ChooseSignal();
            var dr = form.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                listViewStartConditions.Items.Add(new ListViewItem() {Tag = form.Strategy, Text = form.Strategy.Name, Name = Guid.NewGuid().ToString()});
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewStartConditions.SelectedItems)
            {
                listViewStartConditions.Items.RemoveByKey(item.Name);
            }
        }

        private void txtBotname_TextChanged(object sender, EventArgs e)
        {
            RefreshNamePreview();
        }
    }
}
