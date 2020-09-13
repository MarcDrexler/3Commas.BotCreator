using _3Commas.BotCreator.Logic.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3Commas.BotCreator.Tests.Misc
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