using System.Collections.Generic;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Misc
{
    public class CreateBotRequest
    {
        public bool CheckForExistingBots { get; set; }
        public int NumberOfNewBots { get; set; }
        public string QuoteCurrency { get; set; }
        public Strategy Strategy { get; set; }
        public StartOrderType StartOrderType { get; set; }
        public int MaxSafetyOrders { get; set; }
        public int ActiveSafetyOrdersCount { get; set; }
        public decimal SafetyOrderStepPercentage { get; set; }
        public decimal MartingaleVolumeCoefficient { get; set; }
        public decimal MartingaleStepCoefficient { get; set; }
        public decimal TakeProfitPercentage { get; set; }
        public bool TrailingEnabled { get; set; }
        public decimal TrailingDeviation { get; set; }
        public string NameFormula { get; set; }
        public decimal BaseOrderVolume { get; set; }
        public decimal SafetyOrderVolume { get; set; }
        public bool Enable { get; set; }
        public List<BotStrategy> DealStartConditions { get; set; }
        public int CooldownBetweenDeals { get; set; }
        public int AccountId { get; set; }
        public decimal? AmountToBuyInQuoteCurrency { get; set; }
        public bool CheckForBlacklistedPairs { get; set; }
        public bool CheckForBaseStablecoin { get; set; }
        public decimal StopLossPercentage { get; set; }
        public StopLossType StopLossType { get; set; }
        public bool StopLossTimeoutEnabled { get; set; }
        public int StopLossTimeoutInSeconds { get; set; }

        public CreateBotRequest(decimal stopLossPercentage, StopLossType stopLossType, bool stopLossTimeoutEnabled, int stopLossTimeoutInSeconds, bool checkForExistingBots, bool checkForBlacklistedPairs, bool checkForBaseStablecoin, int numberOfNewBots, string quoteCurrency, Strategy strategy, StartOrderType startOrderType, int maxSafetyOrders, int activeSafetyOrdersCount, decimal safetyOrderStepPercentage, decimal martingaleVolumeCoefficient, decimal martingaleStepCoefficient, decimal takeProfitPercentage, bool trailingEnabled, decimal trailingDeviation, string nameFormula, decimal baseOrderVolume, decimal safetyOrderVolume, bool enable, List<BotStrategy> dealStartConditions, int cooldownBetweenDeals, int accountId, decimal? amountToBuyInQuoteCurrency = null)
        {
            StopLossPercentage = stopLossPercentage;
            StopLossType = stopLossType;
            StopLossTimeoutEnabled = stopLossTimeoutEnabled;
            StopLossTimeoutInSeconds = stopLossTimeoutInSeconds;
            CheckForExistingBots = checkForExistingBots;
            NumberOfNewBots = numberOfNewBots;
            QuoteCurrency = quoteCurrency;
            Strategy = strategy;
            StartOrderType = startOrderType;
            MaxSafetyOrders = maxSafetyOrders;
            ActiveSafetyOrdersCount = activeSafetyOrdersCount;
            SafetyOrderStepPercentage = safetyOrderStepPercentage;
            MartingaleVolumeCoefficient = martingaleVolumeCoefficient;
            MartingaleStepCoefficient = martingaleStepCoefficient;
            TakeProfitPercentage = takeProfitPercentage;
            TrailingEnabled = trailingEnabled;
            TrailingDeviation = trailingDeviation;
            NameFormula = nameFormula;
            BaseOrderVolume = baseOrderVolume;
            SafetyOrderVolume = safetyOrderVolume;
            Enable = enable;
            DealStartConditions = dealStartConditions;
            CooldownBetweenDeals = cooldownBetweenDeals;
            AccountId = accountId;
            AmountToBuyInQuoteCurrency = amountToBuyInQuoteCurrency;
            CheckForBlacklistedPairs = checkForBlacklistedPairs;
            CheckForBaseStablecoin = checkForBaseStablecoin;
        }
    }
}