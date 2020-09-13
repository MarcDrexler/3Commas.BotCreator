using System.Collections.Generic;
using System.Threading.Tasks;
using _3Commas.BotCreator.Logic.ExchangeImplementations.Entities;

namespace _3Commas.BotCreator.Logic.ExchangeImplementations
{
    public interface IExchange
    {
        Task<List<Pair>> GetAllPairsByQuoteCurrency(string quoteCurrency);
        Task<PlaceOrderResult> PlaceOrder(Pair pair, decimal amountToBuyInQuoteCurrency);
    }
}