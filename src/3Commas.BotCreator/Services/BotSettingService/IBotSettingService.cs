using System;
using System.Collections.Generic;

namespace _3Commas.BotCreator.Services.BotSettingService
{
    public interface IBotSettingService
    {
        List<BotSettings> GetAll();

        BotSettings GetByName(string name);

        bool Insert(BotSettings settings, string name);

        bool Update(BotSettings settings, Guid id);

        bool Delete(Guid id);
    }
}