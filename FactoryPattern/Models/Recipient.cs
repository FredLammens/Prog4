using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models
{
    public abstract class Recipient
    {
       // protected string address = "undefined";
        //public string Address => address; hmm gebruik van lambda interessant
        public string address { get; protected set; } = "undefined";
    }
}
