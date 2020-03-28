using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    public abstract class Burger : IItem
    {
        public abstract string Name { get; }

        public IPacking packing => new Box();

        public abstract float Price { get; }
    }
}
