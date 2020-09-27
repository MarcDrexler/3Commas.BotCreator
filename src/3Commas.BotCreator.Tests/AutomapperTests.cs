using _3Commas.BotCreator.MappingProfiles;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3Commas.BotCreator.Tests
{
    [TestClass]
    public class AutomapperTests
    {
        [TestMethod]
        public void AutoMapper_Configuration_IsValid()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<BotSettingsProfile>());
            config.AssertConfigurationIsValid();
        }
    }
}
