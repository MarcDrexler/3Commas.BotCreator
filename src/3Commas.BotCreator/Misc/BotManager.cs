using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3Commas.BotCreator.ExchangeImplementations;
using _3Commas.BotCreator.ExchangeImplementations.Entities;
using Microsoft.Extensions.Logging;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Misc
{
    public class BotManager
    {
        private readonly ILogger _logger;
        private readonly IXCommasClient _xCommasClient;
        private readonly IExchange _exchange;
        private string[] Stablecoins => new[] { "AUD", "EURS", "EBASE", "GBP", "USDT", "USDC", "DAI", "TUSD", "BUSD", "PAX", "HUSD", "SUSD", "USDK", "MUSD", "GUSD", "SAI", "EOSDT", "USDS", "BITCNY", "TRYB", "RSV", "BGBP", "QC", "USNBT", "BKRW", "THKD" };

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

        public async Task CreateBots(CreateBotRequest request)
        {
            var existingBots = await GetAllBots();
            var blacklistedPairs = await RetrieveBlacklistedPairs();

            int created = 0;

            _logger.LogInformation($"Retrieving pairs from {_exchange.Name}...");
            var prices = await _exchange.GetAllPairsByQuoteCurrency(request.QuoteCurrency);
            _logger.LogInformation($"{prices.Count} Pairs for {request.QuoteCurrency.ToUpper()} found");

            foreach (var pair in prices.OrderByDescending(x => x.TotalTradedQuoteAssetVolume))
            {
                var symbol = TransformPairTo3CommasSymbolString(pair.QuoteCurrency, pair.BaseCurrency);

                if (SymbolShouldBeSkipped(symbol, request.CheckForExistingBots, request.CheckForBaseStablecoin, request.Strategy, pair, existingBots, request.CheckForBlacklistedPairs, blacklistedPairs)) continue;

                var botName = NameHelper.GenerateBotName(request.NameFormula, symbol, request.Strategy.ToString());
                var bot = CreateBot(botName, symbol, request);
                var response = await _xCommasClient.CreateBotAsync(request.AccountId, request.Strategy, bot);
                if (!response.IsSuccess)
                {
                    _logger.LogError($"Could not create bot for {symbol}: {response.Error.Replace(Environment.NewLine, " ")}");
                    continue;
                }

                if (request.Enable)
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

                if (request.AmountToBuyInQuoteCurrency.HasValue && request.AmountToBuyInQuoteCurrency.Value > 0)
                {
                    var placeOrderResult = await _exchange.PlaceOrder(pair, request.AmountToBuyInQuoteCurrency.Value);
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

                if (created == request.NumberOfNewBots) break;
            }

            _logger.LogInformation($"{created} bots created");
        }

        private bool SymbolShouldBeSkipped(string symbol, bool checkForExistingBots, bool checkForBaseStablecoin, Strategy strategy, Pair pair, List<Bot> existingBots, bool checkForBlacklistedBots, List<string> blacklistedPairs)
        {
            if (checkForBaseStablecoin && Stablecoins.Any(s => s.ToLower() == pair.BaseCurrency.ToLower()))
            {
                _logger.LogInformation($"Skipping {symbol} because base is a stablecoin");
                return true;
            }

            if (checkForBlacklistedBots && blacklistedPairs.Contains(symbol))
            {
                _logger.LogInformation($"Skipping {symbol} because it is blacklisted");
                return true;
            }

            if (IsSymbolIgnored(symbol))
            {
                _logger.LogInformation($"Skipping {symbol}");
                return true;
            }

            if (checkForExistingBots && existingBots.Any(x =>
                x.Pairs.Any(p => p.ToLower() == $"{pair.QuoteCurrency.ToLower()}_{pair.BaseCurrency.ToLower()}") &&
                x.Strategy == strategy))
            {
                _logger.LogInformation($"Bot for {strategy} {symbol} already exist");
                return true;
            }

            return false;
        }

        private Bot CreateBot(string botName, string symbol, CreateBotRequest request)
        {
            var bot = new Bot();

            // Main Settings
            bot.Name = botName;
            bot.IsEnabled = request.Enable;
            bot.Type = "";

            // Pairs
            bot.Pairs = new[] { symbol };
            bot.MaxActiveDeals = 1;

            // Strategy
            bot.Strategy = request.Strategy;
            bot.ProfitCurrency = ProfitCurrency.QuoteCurrency;
            bot.BaseOrderVolume = request.BaseOrderVolume;
            bot.BaseOrderVolumeType = VolumeType.QuoteCurrency;
            bot.SafetyOrderVolume = request.SafetyOrderVolume;
            bot.SafetyOrderVolumeType = VolumeType.QuoteCurrency;
            bot.StartOrderType = request.StartOrderType;

            // Signals
            bot.Strategies = request.DealStartConditions;

            // Stop Loss
            bot.StopLossPercentage = request.StopLossPercentage;
            bot.StopLossType = request.StopLossType;
            bot.StopLossTimeoutEnabled = request.StopLossTimeoutEnabled;
            bot.StopLossTimeoutInSeconds = request.StopLossTimeoutInSeconds;

            // TP
            bot.TakeProfitType = TakeProfitType.Total;
            bot.TakeProfit = request.TakeProfitPercentage;

            // Trailing
            bot.TrailingEnabled = request.TrailingEnabled;
            bot.TrailingDeviation = request.TrailingDeviation;

            // Safety orders
            bot.MaxSafetyOrders = request.MaxSafetyOrders;
            bot.ActiveSafetyOrdersCount = request.ActiveSafetyOrdersCount;
            bot.SafetyOrderStepPercentage = request.SafetyOrderStepPercentage;
            bot.MartingaleVolumeCoefficient = request.MartingaleVolumeCoefficient;
            bot.MartingaleStepCoefficient = request.MartingaleStepCoefficient;

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
}
