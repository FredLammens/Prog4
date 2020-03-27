using StrategyPattern.Models;

namespace StrategyPattern.Interfaces
{
    interface IPaymentStrategy
    {
        bool Pay(Product product);
        bool Pay(int totaalprijs);
    }
}
