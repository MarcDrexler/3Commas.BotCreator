using System.Collections.Generic;
using _3Commas.BotCreator.Infrastructure;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public interface IMainForm : IViewBase
    {
        void BindCombos();
        string QuoteCurrency { get; }
        string Botname { get; }
        Account Account { get; }
        List<string> SelectedStartConditions { get; }
        string SelectedStrategy { get; }
        bool IsBinanceSelected { get; }
        bool IsHuobiSelected { get; }
        string StartOrderType { get; }
        int StartConditionsCount { get; }
        int NumberOfBotsToCreate { get; }
        int CooldownBetweenDeals { get; }
        bool EnableBots { get; }
        decimal SafetyOrderVolume { get; }
        decimal BaseOrderVolume { get; }
        decimal TrailingDeviation { get; }
        bool IsTrailingEnabled { get; }
        decimal TargetProfitPercentage { get; }
        decimal SafetyOrderStepScale { get; }
        decimal SafetyOrderVolumeScale { get; }
        decimal PriceDeviationToOpenSafetyOrders { get; }
        int MaxActiveSafetyTradesCount { get; }
        int MaxSafetyTradesCount { get; }
        bool IsBuyEnabled { get; }
        decimal AmountToBuy { get; }
        bool CheckForExistingBots { get; }
        bool CheckForBlacklistedPairs { get; }
        bool CheckForBaseStablecoins { get; }
        bool StopLossEnabled { get; }
        decimal StopLossPercentage { get; }
        string StopLossType { get; }
        bool StopLossTimeoutEnabled { get; }
        int StopLossTimeoutInSeconds { get; }
        void SetNamePreview(string name);
        void BindAccountsAndSetSelection(List<Account> accounts, Account account);
        void ClearLog();
        void RefreshQuoteCurrencyLabel(string text);
        void SetControlStateToBuyBaseCurrency(bool isEnabled);
        void SetCreateInProgress(bool inProgress);
        void RefreshStartConditions(List<BotStrategy> startConditions);
    }
}