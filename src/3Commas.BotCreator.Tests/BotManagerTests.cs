using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using _3Commas.BotCreator._3CommasLayer;
using _3Commas.BotCreator.ExchangeLayer;
using _3Commas.BotCreator.ExchangeLayer.Entities;
using _3Commas.BotCreator.Misc;
using _3Commas.BotCreator.Views.MainForm;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using XCommas.Net;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Tests
{
    [TestClass]
    public class BotManagerTests
    {
        [TestMethod]
        public async Task CreateBots_Create5Bots_5BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);
            
            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(5));
        }

        [TestMethod]
        public async Task CreateBots_CreateMoreBotsThanPairsAvailable_5BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(10, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(5));
        }

        [TestMethod]
        public async Task CreateBots_Disable_WillNotEnableBots()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);
            
            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.EnableBotAsync(It.IsAny<int>()), Times.Never);
        }

        [TestMethod]
        public async Task CreateBots_Enable_WillEnableBots()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);
            
            // Act
            await target.CreateBots(5, true, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.EnableBotAsync(It.IsAny<int>()), Times.Exactly(5));
        }

        [TestMethod]
        public async Task CreateBots_CheckForExistingBots_4BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();
            request.SkipExistingPairs = true;

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);
            
            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(4));
        }

        [TestMethod]
        public async Task CreateBots_CheckForBlacklistedPairs_4BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();
            request.SkipBlacklistedPairs = true;

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(4));
        }

        [TestMethod]
        public async Task CreateBots_CheckForBaseStablecoins_4BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();
            request.SkipBaseStablecoin = true;

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(4));
        }

        [TestMethod]
        public async Task CreateBots_CheckForExistingBotsAndBlacklistedPairsAndBaseStablecoins_2BotsCreated()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();
            request.SkipExistingPairs = true;
            request.SkipBlacklistedPairs = true;
            request.SkipBaseStablecoin = true;

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            xCommasClient.Verify(x => x.CreateBotAsync(It.IsAny<int>(), request.Strategy, It.IsAny<BotData>()), Times.Exactly(2));
        }

        [TestMethod]
        public async Task CreateBots_NoBuyOrderWanted_WillNotPlaceBuyOrder()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            exchange.Verify(x => x.PlaceOrder(It.IsAny<Pair>(), It.IsAny<decimal>()), Times.Never);
        }

        [TestMethod]
        public async Task CreateBots_BuyOrderWanted_WillPlaceBuyOrder()
        {
            // Arrange
            var exchange = BuildExchangeWith5Pairs();
            var xCommasClient = BuildXCommasClientWith1ExistingAnd1Blacklisted();
            var request = GetDefaultRequest();
            request.BuyBaseCurrency = true;
            request.BaseCurrencyToBuy = (decimal) 123.45;

            var target = new BotManager(NullLogger.Instance, xCommasClient.Object, exchange.Object);

            // Act
            await target.CreateBots(5, false, request, CancellationToken.None);

            // Assert
            exchange.Verify(x => x.PlaceOrder(It.IsAny<Pair>(), (decimal) 123.45), Times.Exactly(5));
        }

        [TestMethod]
        public void TransformPairTo3CommasSymbolStringTest()
        {
            var actual = BotManager.TransformPairTo3CommasSymbolString("USDT", "BNB");

            Assert.AreEqual("USDT_BNB", actual);
        }
        
        private Mock<IXCommasClient> BuildXCommasClientWith1ExistingAnd1Blacklisted()
        {
            var mock = new Mock<IXCommasClient>();
            mock.Setup(x => x.GetBotsAsync(It.IsAny<int>(), 0, Strategy.Long, BotScope.Enabled)).ReturnsAsync(new XCommasResponse<Bot[]>(new[]
            {
                new Bot() {Pairs = new[] {"usdt_btc"}, Strategy = Strategy.Long},
            }, "", ""));
            mock.Setup(x => x.GetBotsAsync(It.IsAny<int>(), 100, Strategy.Long, BotScope.Enabled)).ReturnsAsync(new XCommasResponse<Bot[]>(new Bot[0], "", ""));
            mock.Setup(x => x.GetBotsAsync(It.IsAny<int>(), It.IsAny<int>(), Strategy.Long, BotScope.Disabled)).ReturnsAsync(new XCommasResponse<Bot[]>(new Bot[0], "", ""));
            mock.Setup(x => x.GetBotsAsync(It.IsAny<int>(), It.IsAny<int>(), Strategy.Short, BotScope.Enabled)).ReturnsAsync(new XCommasResponse<Bot[]>(new Bot[0], "", ""));
            mock.Setup(x => x.GetBotsAsync(It.IsAny<int>(), It.IsAny<int>(), Strategy.Short, BotScope.Disabled)).ReturnsAsync(new XCommasResponse<Bot[]>(new Bot[0], "", ""));

            mock.Setup(x => x.GetBotPairsBlackListAsync()).ReturnsAsync(new XCommasResponse<BotPairsBlackListData>(new BotPairsBlackListData() {Pairs = new[] {"USDT_ETH"}}, "", ""));

            mock.Setup(x => x.CreateBotAsync(1000, It.IsAny<Strategy>(), It.IsAny<BotData>())).ReturnsAsync(new XCommasResponse<Bot>(new Bot(), "", ""));
            
            mock.Setup(x => x.EnableBotAsync(It.IsAny<int>())).ReturnsAsync(new XCommasResponse<Bot>(new Bot(), "", ""));

            mock.Setup(x => x.GetCurrencyRateAsync(It.IsAny<string>())).ReturnsAsync(new XCommasResponse<CurrencyRate>(new CurrencyRate(), "", ""));

            return mock;
        }

        private Mock<IExchange> BuildExchangeWith5Pairs()
        {
            var exchange = new Mock<IExchange>();
            exchange.Setup(x => x.GetAllPairsByQuoteCurrency("USDT")).ReturnsAsync(new List<Pair>
            {
                new Pair {BaseCurrency = "BTC", QuoteCurrency = "USDT", TotalTradedQuoteAssetVolume = 10000000},
                new Pair {BaseCurrency = "ETH", QuoteCurrency = "USDT", TotalTradedQuoteAssetVolume = 100000},
                new Pair {BaseCurrency = "LTC", QuoteCurrency = "USDT", TotalTradedQuoteAssetVolume = 10000},
                new Pair {BaseCurrency = "LINK", QuoteCurrency = "USDT", TotalTradedQuoteAssetVolume = 100},
                new Pair {BaseCurrency = "BUSD", QuoteCurrency = "USDT", TotalTradedQuoteAssetVolume = 10},
            });

            exchange.Setup(x => x.PlaceOrder(It.IsAny<Pair>(), (decimal) 123.45)).ReturnsAsync(new PlaceOrderResult() {Success = true});

            return exchange;
        }

        private BotSettingViewModel GetDefaultRequest() => new BotSettingViewModel(LeverageType.NotSpecified, 0, (decimal)0, StopLossType.StopLoss, false, 0, false, false, false, false, "USDT", Strategy.Long, StartOrderType.Limit, 5, 1, 1, 1, 1, (decimal)1.5, false, 0, "{strategy} {pair} Bot", 10, 11, new List<BotStrategy>(), 0, 1000, 0);
    }
}