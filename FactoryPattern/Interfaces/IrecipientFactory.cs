using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    interface IrecipientFactory
    {
        public Recipient CreateRecipient(RecipientType type, string address);
    }
}
