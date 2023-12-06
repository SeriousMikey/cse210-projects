using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "0";

        List<string> mainMenu = new List<string>()
        {
            "View Current Routine",
            "New Routine",
            "View Workout Tip",
            "Edit Exercises",
            "Edit Tips",
            "Save Data",
            "Load Data",
            "Quit"
        };
        
        do
        {
            Console.WriteLine("Menu Options: ");
            int i = 1;
            foreach (string option in mainMenu)
            {
                Console.WriteLine($"  {i}. {option}");
                i++;
            }
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.WriteLine("Showing current routine");
            }

            else if (userChoice == "2")
            {
                Console.WriteLine("Creating a new routine");
            }

            else if (userChoice == "3")
            {
                Console.WriteLine("Showing tip");
            }

            else if (userChoice == "4")
            {
                Console.WriteLine("Editing exercises");
            }

            else if (userChoice == "5")
            {
                Console.WriteLine("Editing tips");
            }

            else if (userChoice == "6")
            {
                Console.WriteLine("Saving data");
            }

            else if (userChoice == "7")
            {
                Console.Write("Which file would you like to load from? ");
                string filename = Console.ReadLine();
                Console.Write("Loading");
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }

                string[] lines = System.IO.File.ReadAllLines(filename);
                
                // Loading Content

                Console.WriteLine();
                Console.Write("Loading Complete! Press enter to continue. ");
                Console.ReadLine();
            }

            else
            {
                userChoice = "quit";
            }
        } while (userChoice != "quit");
    }
}