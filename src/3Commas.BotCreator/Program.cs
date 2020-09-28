using System;
using System.Configuration;
using System.Windows.Forms;
using _3Commas.BotCreator.Infrastructure;
using _3Commas.BotCreator.Services.BotSettingService;
using _3Commas.BotCreator.Services.MessageBoxService;
using _3Commas.BotCreator.Views.AboutBox;
using _3Commas.BotCreator.Views.ChooseSignalView;
using _3Commas.BotCreator.Views.MainForm;
using _3Commas.BotCreator.Views.SaveTemplateView;
using _3Commas.BotCreator.Views.SetApiKeyView;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

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

            try
            {
                ConfigureServices();
                EncryptConfigFile();
                Application.Run((Form) ServiceProvider.GetRequiredService<IMainForm>());
            }
            catch (Exception e)
            {
                MessageBox.Show("Sorry, but something went wrong!" + Environment.NewLine + Environment.NewLine +
                                "Please let me know that there was a problem and I will try to fit it for you. You can report this error here: " +
                                "https://github.com/MarcDrexler/3Commas.BotCreator/issues" + Environment.NewLine + Environment.NewLine +
                                "Error Details: " + Environment.NewLine +
                                e.ToString(), "Sorry!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IMainForm, MainForm>();
            services.AddTransient<SaveTemplateView>();
            services.AddTransient<SetApiKeyView>();
            services.AddTransient<ChooseSignalView>();
            services.AddTransient<AboutBox>();
            services.AddSingleton<IBotSettingService, BotSettingService>();
            services.AddTransient<IMessageBoxService, MessageBoxService>();

            var config = new MapperConfiguration(cfg => cfg.AddMaps(typeof(Program)));
            services.AddSingleton(config.CreateMapper());
            ServiceProvider = services.BuildServiceProvider();
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
