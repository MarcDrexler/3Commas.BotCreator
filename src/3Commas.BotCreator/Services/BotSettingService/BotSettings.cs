using System;
using System.Collections.Generic;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Services.BotSettingService
{
    public class BotSettings
    {
        public BotSettings()
        {
            LogSkipExistingPairs = true;
            LogSkipBaseStablecoin = true;
            LogSkipBlacklistedPairs = true;
            LogSkipExistingBaseCurrencyInAnyExistingPair = true;
        }

        public Guid Id { get; set; }

        public DateTime UpdatedAt { get; set; }

        public string Name { get; set; }

        public bool SkipExistingPairs { get; set; }

        public bool SkipBlacklistedPairs { get; set; }

        public bool SkipBaseStablecoin { get; set; }

        public bool SkipExistingBaseCurrencyInAnyExistingPair { get; set; }

        public bool LogSkipExistingPairs { get; set; }

        public bool LogSkipBlacklistedPairs { get; set; }

        public bool LogSkipBaseStablecoin { get; set; }

        public bool LogSkipExistingBaseCurrencyInAnyExistingPair { get; set; }

        public string QuoteCurrency { get; set; }

        public string Botname { get; set; }

        public int? ExchangeAccountId { get; set; }

        public string Strategy { get; set; }

        public string ProfitCurrency { get; set; }

        public decimal BaseOrderSize { get; set; }

        public string BaseOrderSizeType { get; set; }

        public decimal SafetyOrderSize { get; set; }

        public string SafetyOrderSizeType { get; set; }
        
        public string StartOrderType { get; set; }

        public decimal TargetProfit { get; set; }

        public string TargetProfitType { get; set; }

        public bool TrailingEnabled { get; set; }

        public decimal TrailingDeviation { get; set; }

        public List<BotStrategy> DealStartConditions { get; set; } = new List<BotStrategy>();

        public bool StopLossEnabled { get; set; }

        public decimal StopLossPercentage { get; set; }

        public string StopLossAction { get; set; }

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

        public string LeverageType { get; set; }

        public int LeverageCustomValue { get; set; }

        public bool BuyBaseCurrency { get; set; }

        public decimal BaseCurrencyToBuy { get; set; }
    }
}