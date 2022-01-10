using System.Collections.Generic;
using _3Commas.BotCreator.Infrastructure;
using _3Commas.BotCreator.Services.BotSettingService;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public interface IMainForm : IViewBase
    {
        void BindCombos();
        bool IsBinanceSelected { get; }
        bool IsHuobiSelected { get; }
        int StartConditionsCount { get; }
        int NumberOfBotsToCreate { get; }
        bool Enable { get; }
        List<BotStrategy> SelectedStartConditions { get;}
        BotSettings SelectedTemplate { get; }
        bool UsePaperTrading { get; }
        void SetNamePreview(string name);
        void BindAccountsAndSetSelection(List<Account> accounts, int? account);
        void ClearLog();
        void RefreshQuoteCurrencyLabel(string text);
        void SetControlStateToBuyBaseCurrency(bool isEnabled);
        void SetCreateInProgress(bool inProgress);
        void RefreshStartConditions(List<BotStrategy> startConditions);
        void RefreshTemplateCombo(List<BotSettings> templates, bool selectFirst);
        void BindSetting(BotSettingViewModel botSetting);
    }
}