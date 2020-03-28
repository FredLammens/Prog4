using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    class Water : Drink
    {
        public override string Name => "water";

        public override float Price => 1f;
    }
}
