using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using weeklyDinners.Classes.Calendar;

namespace weeklyDinners.Classes
{
    public class MealPlan
    {
        public readonly string[] side_Carb = { "potato", "Rice", "Bread" };
        public readonly string[] side_Veg = { "Green Beans", "Brussel Sprouts", "Cauliflower", "Broccoli", "Squash", "Asparagus" };
        public readonly string[] dish_Chicken = { "Salsa Chicken", "Chicken Enchilada Bake", "Chicken Parmesan", "Baked Chicken", "Barbeque Chicken", "Crock Pot Chicken" };
        public readonly string[] dish_Fish = { "Salmon", "Shrimp" };
        public readonly string[] dish_Turkey = { "Turkey Chili", "turkey Meatloaf", "Turkey Burger" };
        public readonly string[] dish_Beef = { "Steak", "Meatloaf", "Spaghetti" };
        public string GetItem(string[] stringArray)
        {
            return stringArray[GetRandomIndex(stringArray)];
        }
        public void PrintMealPlan()
        {
            Console.WriteLine($"Monday: Chicken, {GetItem(dish_Chicken)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Tuesday: Fish, {GetItem(dish_Fish)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Wednesday: Out");
            Console.WriteLine($"Thursday: Turkey, {GetItem(dish_Turkey)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Friday: Beef, {GetItem(dish_Beef)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Saturday: Chicken, {GetItem(dish_Chicken)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Sunday: Fish, {GetItem(dish_Fish)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine("<...............................................>");
        }
        static int GetRandomIndex(string[] stringArray)
        {
            Random rand = new Random();
            return rand.Next(stringArray.Length);
        }
    }
}