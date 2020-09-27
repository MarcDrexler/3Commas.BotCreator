using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3Commas.BotCreator.ExchangeLayer.Entities;
using CryptoExchange.Net.Authentication;
using Huobi.Net;
using Huobi.Net.Objects;

namespace _3Commas.BotCreator.ExchangeLayer.Implementations
{
    public class Huobi : IExchange
    {
        public Huobi(Keys settings)
        {
            HuobiClient.SetDefaultOptions(new HuobiClientOptions { ApiCredentials = new ApiCredentials(settings.ApiKeyHuobi, settings.SecretHuobi) });
        }
        public string Name => "Huobi";

        public async Task<List<Pair>> GetAllPairsByQuoteCurrency(string quoteCurrency)
        {
            var pairs = new List<Pair>();
            using (var huobi = new HuobiClient())
            {
                var symbols = (await huobi.GetSymbolsAsync()).Data.Where(x => x.Symbol.ToLower().Contains(quoteCurrency.ToLower())).ToList();
                foreach (var huobiSymbol in symbols)
                {
                    if (huobiSymbol.State == HuobiSymbolState.Online)
                    {
                        var symbolDetails = await huobi.GetSymbolDetails24HAsync(huobiSymbol.Symbol);
                        if (symbolDetails.Data == null)
                        {
                            continue;
                        }

                        var pair = new Pair
                        {
                            TotalTradedQuoteAssetVolume = symbolDetails.Data.Volume.Value,
                            QuoteCurrency = quoteCurrency,
                            BaseCurrency = ExtractBaseCurrency(huobiSymbol.Symbol, quoteCurrency)
                        };
                        pairs.Add(pair);
                    }
                }
            }
            return pairs;
        }

        public async Task<PlaceOrderResult> PlaceOrder(Pair pair, decimal amountToBuyInQuoteCurrency)
        {
            var result = new PlaceOrderResult();
            using (var huobi = new HuobiClient())
            {
                var accounts = await huobi.GetAccountsAsync();
                var response = await huobi.PlaceOrderAsync(accounts.Data.Single().Id, ToHuobiSymbol(pair.QuoteCurrency, pair.BaseCurrency), HuobiOrderType.MarketBuy, amountToBuyInQuoteCurrency);
                if (response.Success)
                {
                    result.Message = $"Market Buy Order placed. ID: {response.Data}";
                    result.Success = true;
                }
                else
                {
                    result.Message = $"Error while placing Order: {response.Error?.Message}";
                }
            }
            return result;
        }

        public string ExtractBaseCurrency(string symbol, string quoteCurrency)
        {
            return symbol.ToUpper().Replace(quoteCurrency.ToUpper(), "");
        }

        public string ToHuobiSymbol(string pairQuoteCurrency, string pairBaseCurrency)
        {
            return $"{pairBaseCurrency.ToUpper()}{pairQuoteCurrency.ToUpper()}";
        }
    }
}
