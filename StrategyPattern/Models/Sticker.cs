namespace StrategyPattern.Models
{
    class Sticker : Product
    {
        public int price { get; private set; }
        public Sticker(int price)
        {
            this.Price = price;
        }
    }
}
