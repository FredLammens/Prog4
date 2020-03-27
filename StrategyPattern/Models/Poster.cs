namespace StrategyPattern.Models
{
    class Poster : Product
    {
        public int price { get; private set; }
        public Poster(int price)
        {
            this.price = price;
        }
    }
}
