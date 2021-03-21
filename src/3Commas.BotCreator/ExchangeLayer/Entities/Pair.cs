using System;

namespace _3Commas.BotCreator.ExchangeLayer.Entities
{
    public class Pair
    {
        public decimal TotalTradedQuoteAssetVolume { get; set; }
        public string QuoteCurrency { get; set; }
        public string BaseCurrency { get; set; }
        public DateTime? TradingStartedOn { get; set; }
    }
}