using System;
using System.Windows.Forms;
using Keys = _3Commas.BotCreator.Misc.Keys;

namespace _3Commas.BotCreator.Views
{
    public partial class Settings : Form
    {
        private readonly Keys keys;

        public Settings(Keys keys)
        {
            this.keys = keys;
            InitializeComponent();

            txtBinanceApiKey.Text = keys.ApiKeyBinance;
            txtBinanceSecret.Text = keys.SecretBinance;
            txt3CommasApiKey.Text = keys.ApiKey3Commas;
            txt3CommasSecret.Text = keys.Secret3Commas;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            keys.ApiKeyBinance = txtBinanceApiKey.Text;
            keys.SecretBinance = txtBinanceSecret.Text;
            keys.ApiKey3Commas = txt3CommasApiKey.Text;
            keys.Secret3Commas = txt3CommasSecret.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
