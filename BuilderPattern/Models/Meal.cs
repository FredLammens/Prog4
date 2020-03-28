using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern.Models
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();
        public void AddItem(IItem itemToAdd) 
        {
            items.Add(itemToAdd);
        }
        public float GetCosts() 
        {
            return items.Sum(item => item.Price);
        }
        public void ShowItems() 
        {
            foreach (IItem item in items)
            {
                Console.WriteLine($"Item : {item.Name}, Packing: {item.packing}, Price {item.Price.ToString("C")}"); // ToString("C") = currency format specifier
            }
        }
    }
}
