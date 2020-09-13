using _3Commas.BotCreator.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3Commas.BotCreator.Tests.ExchangeImplementations.Binance
{
    [TestClass()]
    public class BinanceTests
    {
        [TestMethod()]
        public void ExtractBaseCurrencyTest()
        {
            var actual = new Logic.ExchangeImplementations.Binance.Binance(FakeKeys).ExtractBaseCurrency("usdtbnb", "usdt");

            Assert.AreEqual("BNB", actual);
        }

        [TestMethod()]
        public void ToBinanceSymbolTest()
        {
            var actual = new Logic.ExchangeImplementations.Binance.Binance(FakeKeys).ToBinanceSymbol("usdt", "bnb");

            Assert.AreEqual("BNBUSDT", actual);
        }

        public Keys FakeKeys => new Keys
        {
            ApiKey3Commas = "X",
            ApiKeyBinance = "X",
            Secret3Commas = "X",
            SecretBinance = "X"
        };
    }
}