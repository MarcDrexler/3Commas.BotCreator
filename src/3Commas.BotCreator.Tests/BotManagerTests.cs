using _3Commas.BotCreator.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3Commas.BotCreator.Tests
{
    [TestClass()]
    public class BotManagerTests
    {
        [TestMethod()]
        public void TransformPairTo3CommasSymbolStringTest()
        {
            var actual = BotManager.TransformPairTo3CommasSymbolString("USDT", "BNB");

            Assert.AreEqual("USDT_BNB", actual);
        }
    }
}