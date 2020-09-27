using _3Commas.BotCreator.Services.BotSettingService;
using _3Commas.BotCreator.Views.MainForm;
using AutoMapper;

namespace _3Commas.BotCreator.MappingProfiles
{
    public class BotSettingsProfile : Profile
    {
        public BotSettingsProfile()
        {
            CreateMap<BotSettings, BotSettingViewModel>().ReverseMap();
        }
    }
}
