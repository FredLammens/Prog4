using BuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    class MealBuilder
    {
        public Meal PrepareChickenMeal() 
        {
            Meal chickenMeal = new Meal();
            chickenMeal.AddItem(new Water());
            chickenMeal.AddItem(new ChickenBurger());
            return chickenMeal;
        }
        public Meal PrepareBurgerMeal() 
        {
            Meal meal = new Meal();
            meal.AddItem(new Cola());
            meal.AddItem(new Hamburger());
            return meal;
        }
    }
}
