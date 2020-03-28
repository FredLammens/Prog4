using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    public abstract class Drink : IItem
    {
        public abstract string Name { get; }

        public IPacking packing => new Bottle();

        public abstract float Price { get; }
    }
}
