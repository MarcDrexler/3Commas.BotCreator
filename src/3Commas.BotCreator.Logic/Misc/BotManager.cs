using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3Commas.BotCreator.Logic.ExchangeImplementations;
using Microsoft.Extensions.Logging;
using XCommas.Net;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Logic.Misc
{
    public class BotManager
    {
        private readonly ILogger logger;
        private readonly XCommasApi _3CommasClient;

        public BotManager(Keys settings, ILogger logger)
        {
            this.logger = logger;
            _3CommasClient = new XCommasApi(settings.ApiKey3Commas, settings.Secret3Commas);
        }

        public async Task<List<Account>> RetrieveAccounts()
        {
            var accounts = new List<Account>();

            var response = await _3CommasClient.GetAccountsAsync();
            logger.LogInformation("Retrieving exchange information from 3Commas...");
            if (!response.IsSuccess)
            {
                this.logger.LogError("Problem with 3Commas connection: " + response.Error);
            }
            else
            {
                logger.LogInformation($"{response.Data.Length} Exchanges found");
                accounts = response.Data.ToList();
            }

            return accounts;
        }

        public async Task CreateBots(bool checkForExistingBots, int numberOfNewBots, string quoteCurrency, Strategy strategy, StartOrderType startOrderType, int maxSafetyOrders, int activeSafetyOrdersCount, decimal safetyOrderStepPercentage, decimal martingaleVolumeCoefficient, decimal martingaleStepCoefficient, decimal takeProfitPercentage, bool trailingEnabled, decimal trailingDeviation, string nameFormula, decimal baseOrderVolume, decimal safetyOrderVolume, bool enable, List<BotStrategy> dealStartConditions, int cooldownBetweenDeals, IExchange exchange, int accountId, decimal? amountToBuyInQuoteCurrency = null)
        {
            logger.LogInformation("Retrieving existing Bots from 3commas...");
            var existingBots = await GetAllBots();
            logger.LogInformation($"{existingBots.Count} Bots found");

            int created = 0;

            logger.LogInformation($"Retrieving pairs from {exchange.Name}...");
            var prices = await exchange.GetAllPairsByQuoteCurrency(quoteCurrency);
            logger.LogInformation($"{prices.Count} Pairs for {quoteCurrency.ToUpper()} found");

            foreach (var pair in prices.OrderByDescending(x => x.TotalTradedQuoteAssetVolume))
            {
                var symbol = TransformPairTo3CommasSymbolString(pair.QuoteCurrency, pair.BaseCurrency);

                if (IsSymbolIgnored(symbol))
                {
                    logger.LogInformation($"Skipping {symbol}");
                    continue;
                }

                if (checkForExistingBots && existingBots.Any(x => 
                    x.Pairs.Any(p => p.ToLower() == $"{pair.QuoteCurrency.ToLower()}_{pair.BaseCurrency.ToLower()}") &&
                    x.Strategy == strategy))
                {
                    logger.LogInformation($"Bot for {strategy} {symbol} already exist");
                    continue;
                }

                var botName = Logic.GenerateBotName(nameFormula, symbol, strategy.ToString());
                var bot = CreateBot(strategy, startOrderType, maxSafetyOrders, activeSafetyOrdersCount, safetyOrderStepPercentage, martingaleVolumeCoefficient, martingaleStepCoefficient, takeProfitPercentage, trailingEnabled, trailingDeviation, baseOrderVolume, safetyOrderVolume, enable, dealStartConditions, cooldownBetweenDeals, botName, symbol);
                var response = await _3CommasClient.CreateBotAsync(accountId, strategy, bot);
                if (!response.IsSuccess)
                {
                    logger.LogError($"Could not create bot for {symbol}: {response.Error.Replace(Environment.NewLine, " ")}");
                    continue;
                }

                if (enable)
                {
                    var res = await _3CommasClient.EnableBotAsync(response.Data.Id);
                    if (!res.IsSuccess)
                    {
                        logger.LogError($"Bot '{botName}' created but there was an error with activation: {res.Error.Replace(Environment.NewLine, " ")}");
                    }
                    else
                    {
                        logger.LogInformation($"Bot created and started: '{botName}'");
                    }
                }
                else
                {
                    logger.LogInformation($"Bot created: '{botName}'");
                }

                if (amountToBuyInQuoteCurrency.HasValue && amountToBuyInQuoteCurrency.Value > 0)
                {
                    var placeOrderResult = await exchange.PlaceOrder(pair, amountToBuyInQuoteCurrency.Value);
                    if (placeOrderResult.Success)
                    {
                        logger.LogInformation(placeOrderResult.Message);
                    }
                    else
                    {
                        logger.LogError(placeOrderResult.Message);
                    }
                }

                created++;

                if (created == numberOfNewBots)
                {
                    break;
                }
            }

            logger.LogInformation($"{created} bots created");
        }

        private Bot CreateBot(Strategy strategy, StartOrderType startOrderType, int maxSafetyOrders, int activeSafetyOrdersCount, decimal safetyOrderStepPercentage, decimal martingaleVolumeCoefficient, decimal martingaleStepCoefficient, decimal takeProfitPercentage, bool trailingEnabled, decimal trailingDeviation, decimal baseOrderVolume, decimal safetyOrderVolume, bool enable, List<BotStrategy> dealStartConditions, int cooldownBetweenDeals, string botName, string symbol)
        {
            var bot = new Bot();

            // Main Settings
            bot.Name = botName;
            bot.IsEnabled = enable;
            bot.Type = "";

            // Pairs
            bot.Pairs = new[] { symbol };
            bot.MaxActiveDeals = 1;

            // Strategy
            bot.Strategy = strategy;
            bot.ProfitCurrency = ProfitCurrency.QuoteCurrency;
            bot.BaseOrderVolume = baseOrderVolume;
            bot.BaseOrderVolumeType = VolumeType.QuoteCurrency;
            bot.SafetyOrderVolume = safetyOrderVolume;
            bot.SafetyOrderVolumeType = VolumeType.QuoteCurrency;
            bot.StartOrderType = startOrderType;

            // Signals
            bot.Strategies = dealStartConditions;

            // TP
            bot.TakeProfitType = TakeProfitType.Total;
            bot.TakeProfit = takeProfitPercentage;

            // Trailing
            bot.TrailingEnabled = trailingEnabled;
            bot.TrailingDeviation = trailingDeviation;

            // Safety orders
            bot.MaxSafetyOrders = maxSafetyOrders;
            bot.ActiveSafetyOrdersCount = activeSafetyOrdersCount;
            bot.SafetyOrderStepPercentage = safetyOrderStepPercentage;
            bot.MartingaleVolumeCoefficient = martingaleVolumeCoefficient;
            bot.MartingaleStepCoefficient = martingaleStepCoefficient;

            // Advanced
            bot.Cooldown = cooldownBetweenDeals;
            return bot;
        }

        private bool IsSymbolIgnored(string symbol)
        {
            var pairsToIgnore = new string[]
            {
                "USDT_BUSD",
                "USDT_IDRT",
                "USDT_BIDR",
                "USDT_PAX",
                "USDT_BKRW",
                "USDT_NGN"
            };

            return (symbol.EndsWith("DOWN")
                    || symbol.EndsWith("UP")
                    || symbol.EndsWith("BULL")
                    || symbol.EndsWith("BEAR")
                    || symbol.EndsWith("EUR")
                    || pairsToIgnore.Contains(symbol));
        }

        public static string TransformPairTo3CommasSymbolString(string quoteCurrency, string baseCurrency)
        {
            return $"{quoteCurrency.ToUpper()}_{baseCurrency}";
        }

        public async Task SetManualStrategyForAllBots()
        {
            var bots = await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Enabled);
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Disabled));

            foreach (var bot in bots)
            {
                bot.Strategies.Clear();
                bot.Strategies.Add(new ManualStrategy());
                var result = await _3CommasClient.UpdateBotAsync(bot.Id, new BotUpdateData(bot));
                if (result.IsSuccess)
                {
                    logger.LogInformation($"{bot.Name} updated");
                }
                else
                {
                    logger.LogError($"Error while updating Bot '{bot.Name}': {result.Error}");
                }
            }
        }

        public async Task SetNonstopStrategyForAllBots()
        {
            var bots = await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Enabled);
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Disabled));

            foreach (var bot in bots)
            {
                bot.Strategies.Clear();
                bot.Strategies.Add(new NonStopBotStrategy());
                var result = await _3CommasClient.UpdateBotAsync(bot.Id, new BotUpdateData(bot));
                if (result.IsSuccess)
                {
                    logger.LogInformation($"{bot.Name} updated");
                }
                else
                {
                    logger.LogError($"Error while updating Bot '{bot.Name}': {result.Error}");
                }
            }
        }

        public async Task DeleteBotsStartingWith(string prefix)
        {
            var bots = await GetAllBots();
            int deleted = 0;

            foreach (var bot in bots)
            {
                if (bot.Name.StartsWith(prefix))
                {
                    var response = await _3CommasClient.DeleteBotAsync(bot.Id);
                    if (!response.IsSuccess)
                    {
                        logger.LogError($"Could not delete bot {bot.Name}: {response.Error.Replace(Environment.NewLine, " ")}");
                    }
                    else
                    {
                        deleted++;
                    }
                }
            }

            logger.LogInformation($"{deleted} bots deleted!");
        }

        private async Task<List<Bot>> GetBotsByStrategyAndScope(Strategy strategy, BotScope scope)
        {
            var bots = new List<Bot>();
            int take = 100;
            int skip = 0;
            while (true)
            {
                var result = await _3CommasClient.GetBotsAsync(limit: take, offset: skip, strategy: strategy, botScope: scope);
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
            var bots = await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Enabled);
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Long, BotScope.Disabled));
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Short, BotScope.Enabled));
            bots.AddRange(await GetBotsByStrategyAndScope(Strategy.Short, BotScope.Disabled));
            return bots;
        }

        public async Task BulkEditBotsStartingWith(string prefix)
        {
            var bots = await GetAllBots();
            foreach (var bot in bots)
            {
                if (bot.Name.StartsWith(prefix))
                {
                    var updateData = new BotUpdateData(bot)
                    {
                        BaseOrderVolume = (decimal)10,
                        SafetyOrderVolume = 11,
                        SafetyOrderStepPercentage = 2
                    };
                    await _3CommasClient.UpdateBotAsync(bot.Id, updateData);
                }
            }
        }
    }
}
