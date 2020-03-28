using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Interfaces
{
    public interface IItem
    {
        string Name { get; }
        IPacking packing { get; }
        float Price { get; }
    }
}
