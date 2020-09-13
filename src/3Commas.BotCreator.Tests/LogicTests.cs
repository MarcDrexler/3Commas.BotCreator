using _3Commas.BotCreator;
using _3Commas.BotCreator.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void GetOrderVolumeTest()
        {
            var target = new Logic();

            Assert.AreEqual(28, target.GetOrderVolume(42321));
            Assert.AreEqual(23, target.GetOrderVolume(34567));
            Assert.AreEqual(14, target.GetOrderVolume(21567));
            Assert.AreEqual(10, target.GetOrderVolume(10567));
            Assert.AreEqual(10, target.GetOrderVolume(6567));
            Assert.AreEqual(10, target.GetOrderVolume(367));
            Assert.AreEqual(10, target.GetOrderVolume(10));
            Assert.AreEqual(10, target.GetOrderVolume(0));
        }
    }
}