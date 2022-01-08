using System;
using System.IO;
using weeklyDinners.Classes.Calendar;

namespace weeklyDinners.Classes.Files
{
    internal class FileStuff : MealPlan
    {
        public void addRemoveFolder()
        {
            Console.Write("Do you want to create a new Folder? \n Press y or n: ");
            string createSelection = Console.ReadLine();

            switch (createSelection)
            {
                case "y":
                    CreateDirectory();
                    break;

                case "n":
                    Console.WriteLine("No Folder Created!\n");
                    Console.Write("Do you want to Delete a Folder? \n Press y or n: ");
                    string deleteSelection = Console.ReadLine();

                    switch (deleteSelection)
                    {
                        case "y":
                            DeleteDirectory();
                            break;

                        case "n":
                            Console.WriteLine("No Directory Deleted!");
                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }

                    break;

                default:
                    Console.Write("Invalid option");
                    break;
            }
        }

        void CreateDirectory()
        {
            Console.WriteLine("Enter desired Folder to be added, Name Preceeded by Location - Example (C:/Users/clcag/Desktop/C#/NEW_FOLDER_NAME) \n");
            string path = @Console.ReadLine();
            //Check If Directory Exists
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder Exists Already");
                return;
            }


            Directory.CreateDirectory(path);
            Console.WriteLine("The Directory was Created Successfully at {0}.", Directory.GetCreationTime(path));

            Console.Write($"The Folder {path} Has Been Created!\n");

        }

        void DeleteDirectory()
        {
            Console.WriteLine("Enter desired Folder to be Removed, Name Preceeded by Location - Example (C:/Users/clcag/Desktop/C#/NEW_FOLDER_NAME) \n");
            string path = Console.ReadLine();
            //check If Directory Exists
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("The Directory was Deleted Successfully at {0}.", Directory.GetCreationTime(path));

                Console.Write($"The Folder {path} Has Been Deleted!\n");
                return;
            }
        }

        public void CreateFile()
        {
            Console.WriteLine("Do you want to create a text file?\n type y or n");
            string fileSelection = Console.ReadLine();

            switch (fileSelection)
            {
                case "y":

                    PrintableMealPlan();
                    break;

                case "n":
                    Console.WriteLine("No File Was Created");
                    break;

                default:
                    Console.WriteLine("Incorrect Input");
                    break;
            }
        }

        public void PrintableMealPlan()
        {

            MealPlan meal = new MealPlan();
            Console.WriteLine("Enter a File Name preceeded by location:\n");
            string fileName = Console.ReadLine();

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Cannot open {fileName} for writing");
                Console.WriteLine(e.Message);
                return;
            }

            Console.SetOut(writer);

            Date.NextMonday();
            Console.WriteLine($"Monday: Chicken, {GetItem(dish_Chicken)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Tuesday: Fish, {GetItem(dish_Fish)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Wednesday: Out");
            Console.WriteLine($"Thursday: Turkey, {GetItem(dish_Turkey)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Friday: Beef, {GetItem(dish_Beef)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Saturday: Chicken, {GetItem(dish_Chicken)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine($"Sunday: Fish, {GetItem(dish_Fish)}, {GetItem(side_Veg)}, {GetItem(side_Carb)}");
            Console.WriteLine("<...............................................>");

            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine("Done");
        }
    }

}

