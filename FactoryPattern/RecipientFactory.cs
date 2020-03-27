using FactoryPattern.Interfaces;
using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class RecipientFactory : IrecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address)
        {
            switch (type) 
            {
                case RecipientType.EMAIL:
                    return new EmailRecipient(address);
                case RecipientType.CC:
                    return new CCRecipient(address);
                case RecipientType.BCC:
                    return new EmailRecipient(address);
                default:
                    return new EmailRecipient(address);
            }
        }
    }
}
