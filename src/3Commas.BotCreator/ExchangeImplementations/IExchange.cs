using System.Collections.Generic;
using System.Threading.Tasks;
using _3Commas.BotCreator.ExchangeImplementations.Entities;

namespace _3Commas.BotCreator.ExchangeImplementations
{
    public interface IExchange
    {
        Task<List<Pair>> GetAllPairsByQuoteCurrency(string quoteCurrency);
        Task<PlaceOrderResult> PlaceOrder(Pair pair, decimal amountToBuyInQuoteCurrency);
        string Name { get; }
    }
}