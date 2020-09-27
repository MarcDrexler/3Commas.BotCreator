using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _3Commas.BotCreator.Services.MessageBoxService;
using Newtonsoft.Json;

namespace _3Commas.BotCreator.Services.BotSettingService
{
    public class BotSettingService : IBotSettingService
    {
        private readonly IMessageBoxService _mbs;
        private readonly List<BotSettings> _settings;
        private readonly string _filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BotCreator", "botsettings.json");

        public BotSettingService(IMessageBoxService mbs)
        {
            _mbs = mbs;
            var directory = Path.GetDirectoryName(_filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _settings = JsonConvert.DeserializeObject<List<BotSettings>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                });
            }
            else
            {
                _settings = new List<BotSettings>();
            }
        }

        public List<BotSettings> GetAll()
        {
            return _settings.OrderByDescending(x => x.UpdatedAt).ToList();
        }

        public BotSettings GetByName(string name)
        {
            return _settings.Single(x => x.Name == name);
        }

        public bool Insert(BotSettings settings, string name)
        {
            try
            {
                settings.Id = Guid.NewGuid();
                settings.Name = name;
                settings.UpdatedAt = DateTime.Now;
                _settings.Add(settings);
                Save();
                return true;
            }
            catch (Exception e)
            {
                _mbs.ShowError(e.ToString());
                return false;
            }
        }

        public bool Update(BotSettings settings, Guid id)
        {
            try
            {
                var oldSettings = _settings.Single(x => x.Id == id);
                _settings.Remove(oldSettings);
                settings.Id = Guid.NewGuid();
                settings.UpdatedAt = DateTime.Now;
                settings.Name = oldSettings.Name;
                _settings.Add(settings);
                Save();
                return true;
            }
            catch (Exception e)
            {
                _mbs.ShowError(e.ToString());
                return false;
            }
        }

        public bool Delete(Guid id)
        {
            try
            {
                _settings.RemoveAll(s => s.Id == id);
                Save();
                return true;
            }
            catch (Exception e)
            {
                _mbs.ShowError(e.ToString());
                return false;
            }
        }

        private void Save()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(_settings, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }));
        }
    }
}