using StrategyPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern.Models
{
    class Cart
    {
        List<Product> products;
        public Cart()
        {
            this.products = new List<Product>();
        }
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void ClearCart()
        {
            products.Clear();
        }
        public void MakePayment(IPaymentStrategy Wallet, IPaymentStrategy Paypal)
        {
            foreach (Product product in products)
            {
                if (!Wallet.Pay(product))
                {
                    Paypal.Pay(product);
                }
                else
                {
                    System.Console.WriteLine("Al het geld is op ! :(");
                }
            }
        }
        public void MakePayment(IPaymentStrategy strategy)
        {
            foreach (Product product in products)
            {
                strategy.Pay(product);
            }
        }
        public int GetFullPrice()
        {
            return products.Sum(x => x.GetPrice());
        }
    }
}
