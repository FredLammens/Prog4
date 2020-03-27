using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;

namespace StrategyPattern
{
    class PaypalStrategycs : IPaymentStrategy, ILogin
    {
        public string gebruikersnaam { get; private set; }
        public string wachtwoord { get; private set; }
        private bool logedIn = false;
        public PaypalStrategycs(string gebruikersnaam, string wachtwoord)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
        }
        public bool Pay(Product product)
        {
            if (logedIn)
            {
                Console.WriteLine("paid using Paypal.");
                return true;
            }
            else
            { 
                Console.WriteLine($"user : {gebruikersnaam} is not logged in.");
                return false;
            }
        }
        public void Login(string wachtwoord)
        {
            if (wachtwoord == this.wachtwoord)
            {
                logedIn = true;
                Console.WriteLine($"user : {gebruikersnaam} is logged in.");
            }
        }

        public bool Pay(int totaalprijs)
        {
            if (logedIn)
            {
                Console.WriteLine("paid using Paypal.");
                return true;
            }
            else
            {
                Console.WriteLine($"user : {gebruikersnaam} is not logged in.");
                return false;
            }
        }
    }
}
