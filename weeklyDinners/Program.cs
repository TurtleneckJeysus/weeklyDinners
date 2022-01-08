using System;
using weeklyDinners.Classes;
using weeklyDinners.Classes.Calendar;
using weeklyDinners.Classes.Files;

namespace weeklyDinners
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileStuff filestuff = new FileStuff();
            MealPlan mealplan = new MealPlan();

            filestuff.addRemoveFolder();
            Console.ReadLine();
            filestuff.CreateFile();
            Date.NextMonday();
            mealplan.PrintMealPlan();
            Console.ReadLine();
        }
    }
}