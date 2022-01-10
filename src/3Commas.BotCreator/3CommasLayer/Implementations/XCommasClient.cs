using System.Threading.Tasks;
using XCommas.Net;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator._3CommasLayer.Implementations
{
    public class XCommasClient : IXCommasClient
    {
        private readonly XCommasApi _3CommasClient;

        public XCommasClient(Keys settings, bool usePaperTrading)
        {
            _3CommasClient = new XCommasApi(settings.ApiKey3Commas, settings.Secret3Commas, userMode: usePaperTrading ? UserMode.Paper : UserMode.Real);
        }

        public async Task<XCommasResponse<Bot>> CreateBotAsync(int accountId, Strategy strategy, BotData botData)
        {
            return await _3CommasClient.CreateBotAsync(accountId, strategy, botData);
        }

        public async Task<XCommasResponse<Bot>> UpdateBotAsync(int botId, BotUpdateData botUpdateData)
        {
            return await _3CommasClient.UpdateBotAsync(botId, botUpdateData);
        }

        public async Task<XCommasResponse<Bot[]>> GetBotsAsync(int limit, int offset)
        {
            return await _3CommasClient.GetBotsAsync(limit, offset);
        }

        public async Task<XCommasResponse<Account[]>> GetAccountsAsync()
        {
            return await _3CommasClient.GetAccountsAsync();
        }

        public async Task<XCommasResponse<CurrencyRate>> GetCurrencyRateAsync(string pair)
        {
            return await _3CommasClient.GetCurrencyRateAsync(pair);
        }

        public async Task<XCommasResponse<BotPairsBlackListData>> GetBotPairsBlackListAsync()
        {
            return await _3CommasClient.GetBotPairsBlackListAsync();
        }

        public async Task<XCommasResponse<Bot>> EnableBotAsync(int botId)
        {
            return await _3CommasClient.EnableBotAsync(botId);
        }
    }
}
