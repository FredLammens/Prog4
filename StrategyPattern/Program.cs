using StrategyPattern.Models;
using System;
// categorie Behavioral => wisselen van ene implementatie naar een andere implementatie d.m.v interfaces
namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Cart shoppingCart = new Cart();
            shoppingCart.AddProduct(new Game(50));
            shoppingCart.AddProduct(new Game(15));
            shoppingCart.AddProduct(new Sticker(5));
            shoppingCart.AddProduct(new Poster(10));
            //MAkepayment aanroepen
            var paypal = new PaypalStrategycs();
            shoppingCart.MakePayment(paypal);
            shoppingCart.MakePayment(new WalletStrategy());
        }
    }
}
