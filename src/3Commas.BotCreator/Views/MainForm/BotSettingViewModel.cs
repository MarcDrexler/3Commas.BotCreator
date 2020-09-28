using System;
using System.Collections.Generic;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Views.MainForm
{
    public class BotSettingViewModel
    {
        public BotSettingViewModel()
        {
            // Default Values
            SkipExistingPairs = true;
            SkipBaseStablecoin = true;
            SkipBlacklistedPairs = true;
            QuoteCurrency = "USDT";
            Botname = "{strategy} {pair} Bot";
            BaseOrderSize = 10;
            SafetyOrderSize = 11;
            TargetProfit = 1;
            MaxSafetyTradesCount = 1;
            MaxActiveSafetyTradesCount = 1;
            PriceDeviationToOpenSafetyOrders = 1;
            SafetyOrderVolumeScale = 1;
            SafetyOrderStepScale = 1;
            CooldownBetweenDeals = 0;
            StartOrderType = StartOrderType.Limit;
            Strategy = Strategy.Long;
            StopLossAction = StopLossType.StopLoss;
            StopLossPercentage = (decimal) 1;
            StopLossTimeout = 1;
            LeverageType = LeverageType.NotSpecified;
            LeverageCustomValue = 1;
            ProfitCurrency = ProfitCurrency.QuoteCurrency;
            BaseOrderSizeType = VolumeType.QuoteCurrency;
            SafetyOrderSizeType = VolumeType.QuoteCurrency;
        }

        public BotSettingViewModel(LeverageType leverageType, int customLeverageValue, decimal stopLossPercentage, StopLossType stopLossType, bool stopLossTimeoutEnabled, int stopLossTimeoutInSeconds, bool checkForExistingBots, bool checkForBlacklistedPairs, bool checkForBaseStablecoin, string quoteCurrency, Strategy strategy, StartOrderType startOrderType, int maxSafetyOrders, int activeSafetyOrdersCount, decimal safetyOrderStepPercentage, decimal martingaleVolumeCoefficient, decimal martingaleStepCoefficient, decimal takeProfitPercentage, bool trailingEnabled, decimal trailingDeviation, string nameFormula, decimal baseOrderVolume, decimal safetyOrderVolume, List<BotStrategy> dealStartConditions, int cooldownBetweenDeals, int accountId, decimal amountToBuyInQuoteCurrency)
        {
            LeverageType = leverageType;
            LeverageCustomValue = customLeverageValue;
            StopLossPercentage = stopLossPercentage;
            StopLossAction = stopLossType;
            StopLossTimeoutEnabled = stopLossTimeoutEnabled;
            StopLossTimeout = stopLossTimeoutInSeconds;
            SkipExistingPairs = checkForExistingBots;
            QuoteCurrency = quoteCurrency;
            Strategy = strategy;
            StartOrderType = startOrderType;
            MaxSafetyTradesCount = maxSafetyOrders;
            MaxActiveSafetyTradesCount = activeSafetyOrdersCount;
            PriceDeviationToOpenSafetyOrders = safetyOrderStepPercentage;
            SafetyOrderVolumeScale = martingaleVolumeCoefficient;
            SafetyOrderStepScale = martingaleStepCoefficient;
            TargetProfit = takeProfitPercentage;
            TrailingEnabled = trailingEnabled;
            TrailingDeviation = trailingDeviation;
            Botname = nameFormula;
            BaseOrderSize = baseOrderVolume;
            SafetyOrderSize = safetyOrderVolume;
            DealStartConditions = dealStartConditions;
            CooldownBetweenDeals = cooldownBetweenDeals;
            ExchangeAccountId = accountId;
            BaseCurrencyToBuy = amountToBuyInQuoteCurrency;
            SkipBlacklistedPairs = checkForBlacklistedPairs;
            SkipBaseStablecoin = checkForBaseStablecoin;
        }

        public string Name { get; set; }
        
        public LeverageType LeverageType { get; set; }

        public int LeverageCustomValue { get; set; }

        public bool SkipExistingPairs { get; set; }

        public bool SkipBlacklistedPairs { get; set; }

        public bool SkipBaseStablecoin { get; set; }

        public string QuoteCurrency { get; set; }

        public string Botname { get; set; }

        public int? ExchangeAccountId { get; set; }

        public Strategy Strategy { get; set; }

        public ProfitCurrency ProfitCurrency { get; set; }

        public decimal BaseOrderSize { get; set; }

        public VolumeType BaseOrderSizeType { get; set; }

        public decimal SafetyOrderSize { get; set; }

        public VolumeType SafetyOrderSizeType { get; set; }

        public StartOrderType StartOrderType { get; set; }

        public decimal TargetProfit { get; set; }

        public string TargetProfitType { get; set; }

        public bool TrailingEnabled { get; set; }

        public decimal TrailingDeviation { get; set; }

        public List<BotStrategy> DealStartConditions { get; set; } = new List<BotStrategy>();

        public bool StopLossEnabled { get; set; }

        public decimal StopLossPercentage { get; set; }

        public StopLossType StopLossAction { get; set; }

        public bool StopLossTimeoutEnabled { get; set; }

        public int StopLossTimeout { get; set; }

        public int MaxSafetyTradesCount { get; set; }

        public int MaxActiveSafetyTradesCount { get; set; }

        public decimal PriceDeviationToOpenSafetyOrders { get; set; }

        public decimal SafetyOrderVolumeScale { get; set; }

        public decimal SafetyOrderStepScale { get; set; }

        public decimal DontStartDealIfDailyVolumeIsLessThan { get; set; }

        public decimal? MinimumPriceToOpenDeal { get; set; }

        public decimal? MaxPriceToOpenDeal { get; set; }

        public int CooldownBetweenDeals { get; set; }

        public int? OpenDealsAndStopCount { get; set; }

        public bool BuyBaseCurrency { get; set; }

        public decimal BaseCurrencyToBuy { get; set; }
    }
}