using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Bottle : IPacking
    {
        public string Pack
        {
            get { return "Bottle"; } // getter voor Pack
        }
    }
}
