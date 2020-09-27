using System.Threading.Tasks;
using XCommas.Net;
using XCommas.Net.Objects;

namespace _3Commas.BotCreator._3CommasLayer
{
    public interface IXCommasClient
    {
        Task<XCommasResponse<BotPairsBlackListData>> GetBotPairsBlackListAsync();

        Task<XCommasResponse<Bot>> EnableBotAsync(int botId);

        Task<XCommasResponse<Bot>> CreateBotAsync(int accountId, Strategy strategy, BotData botData);

        Task<XCommasResponse<Bot>> UpdateBotAsync(int botId, BotUpdateData botUpdateData);

        Task<XCommasResponse<Bot[]>> GetBotsAsync(int limit, int offset, Strategy strategy, BotScope botScope);

        Task<XCommasResponse<Account[]>> GetAccountsAsync();
    }
}