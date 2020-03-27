using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
        public void MakePayment(IPaymentStrategy strategy) 
        {
            foreach (Product product in products)
            {
            strategy.Pay(product);
            }
        }
    }
}
