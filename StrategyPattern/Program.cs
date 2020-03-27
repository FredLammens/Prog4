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
            var payal = new PaypalStrategycs("frederic", "1234", 10000.00m);
            payal.Login("1234");
            shoppingCart.MakePayment(paypal);
            shoppingCart.MakePayment(new WalletStrategy(-9.123m));
        }
    }
}
