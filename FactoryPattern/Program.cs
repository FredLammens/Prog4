using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancing recipients
            IrecipientFactory recipientFactory = new RecipientFactory();
            Recipient emailRecipient = recipientFactory.CreateRecipient(RecipientType.EMAIL, "jef.pieters@gmail.com");
            Recipient ccRecipient = recipientFactory.CreateRecipient(RecipientType.CC, "jan.janssens@hotmail.com");
            Recipient bccRecipient = recipientFactory.CreateRecipient(RecipientType.BCC, "tom.vervoort@live.nl");
            //showing data
            Console.WriteLine($"Created a recipient of type {emailRecipient.GetType()} with address: {emailRecipient.address}");
            Console.WriteLine($"Created a recipient of type {ccRecipient.GetType()} with address: {ccRecipient.address}"); 
            Console.WriteLine($"Created a recipient of type {bccRecipient.GetType()} with address: {bccRecipient.address}");
            //
            Console.ReadKey();
        }
    }
}
