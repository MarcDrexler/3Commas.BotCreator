using _3Commas.BotCreator.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator.Tests
{
    [TestClass]
    public class NameHelperTests
    {
        [TestMethod]
        public void GenerateBotNameTest()
        {
            var actual = NameHelper.GenerateBotName("My new {pair} {strategy} bot", "USDT_BNB", Strategy.Long);

            Assert.AreEqual("My new USDT_BNB Long bot", actual);
        }
    }
}