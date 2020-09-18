using System;
using System.Configuration;
using System.Windows.Forms;
using _3Commas.BotCreator.Views.MainForm;

namespace _3Commas.BotCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EncryptConfigFile();
            Application.Run(new MainForm());
        }

        private static void EncryptConfigFile()
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
            ConfigurationSection section = config.GetSection("userSettings/_3Commas.BotCreator.Properties.Settings");
            section.SectionInformation.ProtectSection("RsaProtectedConfigurationProvider");
            section.SectionInformation.ForceSave = true;
            config.Save(ConfigurationSaveMode.Full);
        }
    }
}
