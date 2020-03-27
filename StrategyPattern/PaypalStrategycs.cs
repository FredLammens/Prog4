using StrategyPattern.Interfaces;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class PaypalStrategycs : IPaymentStrategy , ILogin , IBudget
    {
        decimal budget;
        public string gebruikersnaam { get;private set; }
        public string wachtwoord { get;private set; }
        private bool logedIn = false;
        public PaypalStrategycs(string gebruikersnaam,string wachtwoord, decimal budget)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.budget = budget;
        }
        public void Pay(Product product)
        {
            if (product.GetPrice() <= GetBudget()) 
            {
            if(logedIn)
            Console.WriteLine("paid using Paypal.");
            else
            Console.WriteLine($"user : {gebruikersnaam} is not logged in.");
            }else
                Console.WriteLine("Buget is te klein om dit product te kunnen kopen.");
        }
        public void Login(string wachtwoord) 
        {
            if (wachtwoord == this.wachtwoord) 
            {
                logedIn = true;
                Console.WriteLine($"user : {gebruikersnaam} is logged in.");
            }
        }

        public decimal GetBudget()
        {
            return budget;
        }
    }
}
