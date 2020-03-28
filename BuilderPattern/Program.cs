using BuilderPattern.Models;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder builder = new MealBuilder();
            //burgerMeal
            Meal burgerMeal = builder.PrepareBurgerMeal();
            Console.WriteLine("BurgerMeal: ");
            burgerMeal.ShowItems();
            Console.WriteLine($"Costs: {burgerMeal.GetCosts().ToString("C")}");
            //ChickenMEal
            Meal chickenMeal = builder.PrepareChickenMeal();
            Console.WriteLine("ChickenMeal: ");
            chickenMeal.ShowItems();
            Console.WriteLine("Costs: {0}", chickenMeal.GetCosts().ToString("C"));
            //zorgen dat console niet direct sluit
            Console.ReadKey();
        }
    }
}
