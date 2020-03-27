namespace StrategyPattern.Models
{
    public class Game : Product
    {
        public int price { get; private set; }
        public Game(int price)
        {
            this.price = price;
        }
    }
}
