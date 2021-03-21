using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using _3Commas.BotCreator._3CommasLayer;
using _3Commas.BotCreator.ExchangeLayer;
using _3Commas.BotCreator.ExchangeLayer.Entities;
using _3Commas.BotCreator.Views.MainForm;
using Binance.Net.Objects.Spot.IsolatedMarginData;
using Microsoft.Extensions.Logging;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Misc
{
    public class BotManager
    {
        private readonly ILogger _logger;
        private readonly IXCommasClient _xCommasClient;
        private readonly IExchange _exchange;
        private static string[] Stablecoins => new[] { "AUD", "EUR", "EURS", "EBASE", "GBP", "USDT", "USDC", "DAI", "TUSD", "BUSD", "PAX", "HUSD", "SUSD", "USDK", "MUSD", "GUSD", "SAI", "EOSDT", "USDS", "BITCNY", "TRYB", "RSV", "BGBP", "QC", "USNBT", "BKRW", "THKD" };

        public BotManager(ILogger logger, IXCommasClient xCommasClient, IExchange exchange)
        {
            this._logger = logger;
            _xCommasClient = xCommasClient;
            _exchange = exchange;
        }

        public async Task<List<Account>> RetrieveAccounts()
        {
            var accounts = new List<Account>();

            var response = await _xCommasClient.GetAccountsAsync();
            _logger.LogInformation("Retrieving exchange information from 3Commas...");
            if (!response.IsSuccess)
            {
                this._logger.LogError("Problem with 3Commas connection: " + response.Error);
            }
            else
            {
                _logger.LogInformation($"{response.Data.Length} Exchanges found");
                accounts = response.Data.ToList();
            }

            return accounts;
        }

        public async Task<List<string>> RetrieveBlacklistedPairs()
        {
            var pairs = new List<string>();

            var response = await _xCommasClient.GetBotPairsBlackListAsync();
            _logger.LogInformation("Retrieving pairs blacklist from 3Commas...");
            if (!response.IsSuccess)
            {
                this._logger.LogError("Problem with 3Commas connection: " + response.Error);
            }
            else
            {
                _logger.LogInformation($"{response.Data.Pairs.Length} blacklisted pairs found");
                pairs = response.Data.Pairs.ToList();
            }

            return pairs;
        }

        public async Task PreviewBotsCreation(int numberOfBots, BotSettingViewModel settings, CancellationToken cancellationToken)
        {
            var existingBots = await GetAllBots();
            var blacklistedPairs = await RetrieveBlacklistedPairs();

            int created = 0;

            _logger.LogInformation($"Retrieving pairs from {_exchange.Name}...");
            var prices = await _exchange.GetAllPairsByQuoteCurrency(settings.QuoteCurrency);
            _logger.LogInformation($"{prices.Count} Pairs for {settings.QuoteCurrency.ToUpper()} found");

            foreach (var pair in prices.OrderByDescending(x => x.TotalTradedQuoteAssetVolume))
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    _logger.LogInformation($"Operation cancelled!");
                    break;
                }

                var symbol = TransformPairTo3CommasSymbolString(pair.QuoteCurrency, pair.BaseCurrency);

                if (SymbolShouldBeSkipped(symbol, settings.SkipMinVolume, settings.LogSkipMinVolume, settings.SkipExistingBaseCurrencyInAnyExistingPair, settings.LogSkipExistingBaseCurrencyInAnyExistingPair, settings.SkipExistingPairs, settings.LogSkipExistingPairs, settings.SkipBaseStablecoin, settings.LogSkipBaseStablecoin, settings.Strategy, pair, existingBots, settings.SkipBlacklistedPairs, settings.LogSkipBlacklistedPairs, blacklistedPairs, settings.SkipFirstTradeXDaysAgo, settings.LogSkipFirstTradeXDaysAgo, settings.SkipUpDownPairs, settings.LogSkipUpDownPairs)) continue;
                
                var marketData = await _xCommasClient.GetCurrencyRateAsync(symbol);
                if (!marketData.IsSuccess)
                {
                    if (!marketData.Error.StartsWith("Unknown pair"))
                    {
                        _logger.LogInformation($"Skipped Pair {symbol}. Reason: '{marketData.Error}'");
                    }
                    continue;
                }

                var botName = NameHelper.GenerateBotName(settings.Botname, symbol, settings.Strategy);
                _logger.LogInformation($"Bot to be created: '{botName}'");

                if (settings.BuyBaseCurrency && settings.BaseCurrencyToBuy > 0)
                {
                    _logger.LogInformation($"Market Buy Order to be placed: {settings.BaseCurrencyToBuy} {pair.QuoteCurrency}");
                }

                created++;

                if (created == numberOfBots) break;
            }

            _logger.LogInformation($"{created} bots to be created");
        }

        public async Task CreateBots(int numberOfBots, bool enable, BotSettingViewModel settings, CancellationToken cancellationToken)
        {
            var existingBots = await GetAllBots();
            var blacklistedPairs = await RetrieveBlacklistedPairs();

            int created = 0;

            _logger.LogInformation($"Retrieving pairs from {_exchange.Name}...");
            var prices = await _exchange.GetAllPairsByQuoteCurrency(settings.QuoteCurrency);
            _logger.LogInformation($"{prices.Count} Pairs for {settings.QuoteCurrency.ToUpper()} found");

            foreach (var pair in prices.OrderByDescending(x => x.TotalTradedQuoteAssetVolume))
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    _logger.LogInformation($"Operation cancelled!");
                    break;
                }

                var symbol = TransformPairTo3CommasSymbolString(pair.QuoteCurrency, pair.BaseCurrency);
                
                if (SymbolShouldBeSkipped(symbol, settings.SkipMinVolume, settings.LogSkipMinVolume, settings.SkipExistingBaseCurrencyInAnyExistingPair, settings.LogSkipExistingBaseCurrencyInAnyExistingPair, settings.SkipExistingPairs, settings.LogSkipExistingPairs, settings.SkipBaseStablecoin, settings.LogSkipBaseStablecoin, settings.Strategy, pair, existingBots, settings.SkipBlacklistedPairs, settings.LogSkipBlacklistedPairs, blacklistedPairs, settings.SkipFirstTradeXDaysAgo, settings.LogSkipFirstTradeXDaysAgo, settings.SkipUpDownPairs, settings.LogSkipUpDownPairs)) continue;

                var marketData = await _xCommasClient.GetCurrencyRateAsync(symbol);
                if (!marketData.IsSuccess)
                {
                    if (!marketData.Error.StartsWith("Unknown pair"))
                    {
                        _logger.LogInformation($"Skipped Pair {symbol}. Reason: '{marketData.Error}'");
                    }
                    continue;
                }

                var botName = NameHelper.GenerateBotName(settings.Botname, symbol, settings.Strategy);

                var bot = CreateBot(botName, enable, symbol, settings);
                var response = await _xCommasClient.CreateBotAsync(settings.ExchangeAccountId.Value, settings.Strategy, bot);
                if (!response.IsSuccess)
                {
                    _logger.LogError($"Could not create bot for {symbol}: {response.Error.Replace(Environment.NewLine, " ")}");
                    continue;
                }

                if (enable)
                {
                    var res = await _xCommasClient.EnableBotAsync(response.Data.Id);
                    if (!res.IsSuccess)
                    {
                        _logger.LogError($"Bot '{botName}' created but there was an error with activation: {res.Error.Replace(Environment.NewLine, " ")}");
                    }
                    else
                    {
                        _logger.LogInformation($"Bot created and started: '{botName}'");
                    }
                }
                else
                {
                    _logger.LogInformation($"Bot created: '{botName}'");
                }

                if (settings.BuyBaseCurrency && settings.BaseCurrencyToBuy > 0)
                {
                    var placeOrderResult = await _exchange.PlaceOrder(pair, settings.BaseCurrencyToBuy);
                    if (placeOrderResult.Success)
                    {
                        _logger.LogInformation(placeOrderResult.Message);
                    }
                    else
                    {
                        _logger.LogError(placeOrderResult.Message);
                    }
                }

                created++;

                if (created == numberOfBots) break;
            }

            _logger.LogInformation($"{created} bots created");
        }

        private bool SymbolShouldBeSkipped(string symbol, long? checkForMinVolume, bool logCheckForMinVolume, bool checkForExistingPairWithSameBaseCurrency, bool logCheckForExistingPairWithSameBaseCurrency, bool checkForExistingBots, bool logCheckForExistingBots, bool checkForBaseStablecoin, bool logCheckForBaseStablecoin, Strategy strategy, Pair pair, List<Bot> existingBots, bool checkForBlacklistedBots, bool logCheckForBlacklistedBots, List<string> blacklistedPairs, int daysSinceFirstTrade, bool logSkipFirstTradeXDaysAgo, bool skipUpDownPairs, bool logSkipUpDownPairs)
        {
            if (skipUpDownPairs && IsSymbolIgnored(symbol))
            {
                if (logSkipUpDownPairs) _logger.LogInformation($"Skipping {symbol}");
                return true;
            }

            if (checkForMinVolume.HasValue && pair.TotalTradedQuoteAssetVolume < checkForMinVolume.Value)
            {
                if (logCheckForMinVolume) _logger.LogInformation($"Skipping {symbol} because volume is too low: {pair.TotalTradedQuoteAssetVolume} {pair.QuoteCurrency}");
                return true;
            }

            if (daysSinceFirstTrade > 0 && pair.TradingStartedOn.HasValue && (DateTime.Today - pair.TradingStartedOn.Value).TotalDays < daysSinceFirstTrade)
            {
                if (logSkipFirstTradeXDaysAgo) _logger.LogInformation($"Skipping {symbol} because first trade was on {pair.TradingStartedOn.Value.ToShortDateString()}");
                return true;
            }

            if (checkForBaseStablecoin && Stablecoins.Any(s => s.ToLower() == pair.BaseCurrency.ToLower()))
            {
                if (logCheckForBaseStablecoin) _logger.LogInformation($"Skipping {symbol} because base is a stablecoin");
                return true;
            }

            if (checkForBlacklistedBots && blacklistedPairs.Contains(symbol))
            {
                if (logCheckForBlacklistedBots) _logger.LogInformation($"Skipping {symbol} because it is blacklisted");
                return true;
            }

            if (checkForExistingBots && existingBots.Any(x =>
                x.Pairs.Any(p => p.ToLower() == $"{pair.QuoteCurrency.ToLower()}_{pair.BaseCurrency.ToLower()}") &&
                x.Strategy == strategy))
            {
                if (logCheckForExistingBots) _logger.LogInformation($"Bot for {strategy} {symbol} already exist");
                return true;
            }

            if (checkForExistingPairWithSameBaseCurrency)
            {
                var existingBotsWithSameBase = existingBots.Where(x =>
                    x.Pairs.Any(p => p.ToLower().Split('_').Last() == $"{pair.BaseCurrency.ToLower()}") &&
                    x.Strategy == strategy).ToList();

                if (existingBotsWithSameBase.Any())
                {
                    if (logCheckForExistingPairWithSameBaseCurrency) _logger.LogInformation($"Bots for {strategy} with BaseCurrency {pair.BaseCurrency.ToUpper()} already exist: {string.Join(" / ", existingBotsWithSameBase.SelectMany(x => x.Pairs))}");
                    return true;
                }
            }

            return false;
        }

        private Bot CreateBot(string botName, bool enabled, string symbol, BotSettingViewModel request)
        {
            var bot = new Bot();

            // Main Settings
            bot.Name = botName;
            bot.IsEnabled = enabled;
            bot.Type = "";

            // Pairs
            bot.Pairs = new[] { symbol };
            bot.MaxActiveDeals = 1;

            // Strategy
            bot.Strategy = request.Strategy;
            bot.ProfitCurrency = request.ProfitCurrency;
            bot.BaseOrderVolume = request.BaseOrderSize;
            bot.BaseOrderVolumeType = request.BaseOrderSizeType;
            bot.SafetyOrderVolume = request.SafetyOrderSize;
            bot.SafetyOrderVolumeType = request.SafetyOrderSizeType;
            bot.StartOrderType = request.StartOrderType;

            // Leverage
            bot.LeverageType = request.LeverageType;
            if (request.LeverageType != LeverageType.NotSpecified)
            {
                bot.LeverageCustomValue = request.LeverageCustomValue;
            }

            // Signals
            bot.Strategies = request.DealStartConditions;
            
            // Stop Loss
            decimal stopLossPercentage = 0;
            StopLossType stopLossType = StopLossType.StopLoss;
            bool stopLossTimeoutEnabled = false;
            int stopLossTimeoutInSeconds = 0;
            if (request.StopLossEnabled)
            {
                stopLossPercentage = request.StopLossPercentage;
                stopLossType = request.StopLossAction;
                stopLossTimeoutEnabled = request.StopLossTimeoutEnabled;
                stopLossTimeoutInSeconds = request.StopLossTimeout;
            }

            bot.StopLossPercentage = stopLossPercentage;
            bot.StopLossType = stopLossType;
            bot.StopLossTimeoutEnabled = stopLossTimeoutEnabled;
            bot.StopLossTimeoutInSeconds = stopLossTimeoutInSeconds;

            // TP
            bot.TakeProfitType = TakeProfitType.Total;
            bot.TakeProfit = request.TargetProfit;

            // Trailing
            bot.TrailingEnabled = request.TrailingEnabled;
            bot.TrailingDeviation = request.TrailingDeviation;

            // Safety orders
            bot.MaxSafetyOrders = request.MaxSafetyTradesCount;
            bot.ActiveSafetyOrdersCount = request.MaxActiveSafetyTradesCount;
            bot.SafetyOrderStepPercentage = request.PriceDeviationToOpenSafetyOrders;
            bot.MartingaleVolumeCoefficient = request.SafetyOrderVolumeScale;
            bot.MartingaleStepCoefficient = request.SafetyOrderStepScale;

            // Advanced
            bot.Cooldown = request.CooldownBetweenDeals;
            return bot;
        }

        private bool IsSymbolIgnored(string symbol)
        {
            return symbol.EndsWith("DOWN")
                   || symbol.EndsWith("UP")
                   || symbol.EndsWith("BULL")
                   || symbol.EndsWith("BEAR");
        }

        public static string TransformPairTo3CommasSymbolString(string quoteCurrency, string baseCurrency)
        {
            return $"{quoteCurrency.ToUpper()}_{baseCurrency}";
        }

        private async Task<List<Bot>> GetBotsByStrategyAndScope(Strategy strategy, BotScope scope)
        {
            var bots = new List<Bot>();
            int take = 100;
            int skip = 0;
            while (true)
            {
                var result = await _xCommasClient.GetBotsAsync(limit: take, offset: skip, strategy: strategy, botScope: scope);
                if (!result.IsSuccess)
                {
                    throw new Exception("3Commas Connection Issue: " + result.Error);
                }
                if (result.Data.Length == 0)
                {
                    break;
                }

                bots.AddRange(result.Data);
                skip += take;
            }

            return bots;
        }

        private async Task<List<Bot>> GetAllBots()
        {
            _logger.LogInformation("Retrieving existing Bots from 3commas...");

            var bots = await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Enabled);
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Disabled));
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Short, BotScope.Enabled));
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Short, BotScope.Disabled));

            _logger.LogInformation($"{bots.Count} Bots found");
            return bots;
        }
    }

    public class CreateSettings
    {

    }
}
