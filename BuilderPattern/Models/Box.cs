using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Box : IPacking
    {
        public string Pack { get { return "Box"; } }
    }
}
