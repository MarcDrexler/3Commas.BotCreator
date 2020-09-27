using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3Commas.BotCreator.ExchangeLayer.Entities;
using Binance.Net;
using Binance.Net.Enums;
using Binance.Net.Objects.Spot;
using CryptoExchange.Net.Authentication;

namespace _3Commas.BotCreator.ExchangeLayer.Implementations
{
    public class Binance : IExchange
    {
        public Binance(Keys settings)
        {
            BinanceClient.SetDefaultOptions(new BinanceClientOptions { ApiCredentials = new ApiCredentials(settings.ApiKeyBinance, settings.SecretBinance) });
        }

        public string Name => "Binance";

        public async Task<List<Pair>> GetAllPairsByQuoteCurrency(string quoteCurrency)
        {
            using (var binance = new BinanceClient())
            {
                return (await binance.Spot.Market.Get24HPricesAsync()).Data.Where(x => x.Symbol.ToLower().Contains(quoteCurrency.ToLower())).Select(x => new Pair
                {
                    TotalTradedQuoteAssetVolume = x.QuoteVolume,
                    QuoteCurrency = quoteCurrency,
                    BaseCurrency = ExtractBaseCurrency(x.Symbol, quoteCurrency)
                }).ToList();
            }
        }

        public async Task<PlaceOrderResult> PlaceOrder(Pair pair, decimal amountToBuyInQuoteCurrency)
        {
            var result = new PlaceOrderResult();
            using (var binance = new BinanceClient())
            {
                var response = await binance.Spot.Order.PlaceOrderAsync(ToBinanceSymbol(pair.QuoteCurrency, pair.BaseCurrency), OrderSide.Buy, OrderType.Market, quoteOrderQuantity: amountToBuyInQuoteCurrency);
                if (response.Success)
                {
                    result.Message = $"Market Buy Order placed: {response.Data.Quantity} {pair.BaseCurrency} / {response.Data.QuoteQuantityFilled} {pair.QuoteCurrency}";
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

        public string ToBinanceSymbol(string pairQuoteCurrency, string pairBaseCurrency)
        {
            return $"{pairBaseCurrency.ToUpper()}{pairQuoteCurrency.ToUpper()}";
        }
    }
}
