using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        string userChoice = "";

        List<string> menuOptions = new List<string>() 
            {
                "Create New Goal",
                "Display Goals",
                "Record Event",
                "Save Goals",
                "Load Goals",
                "Quit"
            };

            List<string> goalTypes = new List<string>()
            {
                "Simple Goal",
                "Eternal Goal",
                "Checklist Goal"
            };

            List<Goal> goalsList = new List<Goal>();


        do {
            Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            int i = 1;
            foreach (string option in menuOptions)
            {
                Console.WriteLine($"  {i}. {option}");
                i++;
            }
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();
                Goal newGoal = CreateGoal(goalTypes);
                goalsList.Add(newGoal);
            }

            else if (userChoice == "2")
            {
                if (goalsList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("There are currently no goals to display. Please add a goal. ");
                    Console.Write("Press enter to continue. ");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    DisplayGoals(goalsList);
                }
            }

            else if (userChoice == "3")
            {
                Console.Clear();
                points += RecordEvent(goalsList);
                Console.WriteLine($"You now have {points} points. ");
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }

            else if (userChoice == "4")
            {
                SaveGoals(goalsList, points);
            }

            else if (userChoice == "5")
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
                int k = 0;
                foreach (string line in lines)
                {
                    if (k > 0)
                    {
                        string[] parts = line.Split("::");

                        string goalType = parts[0];
                        string goalName = parts[1];
                        string goalDesc = parts[2];
                        string almostPoints = parts[3];
                        string goalStatus = parts[4];

                        int goalPoints = int.Parse(almostPoints);

                        if (goalType == "SimpleGoal")
                        {
                            SimpleGoal newGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
                            goalsList.Add(newGoal);
                            if (goalStatus == "True")
                            {
                                newGoal.MarkComplete();
                            }
                        }
                        else if (goalType == "EternalGoal")
                        {
                            EternalGoal newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
                            goalsList.Add(newGoal);
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            string almostBonus = parts[5];
                            string almostAmount = parts[6];
                            string almostAmountCompleted = parts[7];

                            int goalBonus = int.Parse(almostBonus);
                            int goalAmount = int.Parse(almostAmount);
                            int goalAmountCompleted = int.Parse(almostAmountCompleted);

                            ChecklistGoal newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, goalBonus, goalAmount, goalAmountCompleted);
                            goalsList.Add(newGoal);
                            if (goalStatus == "True")
                            {
                                newGoal.MarkComplete();
                            }
                        }

                    }
                    else
                    {
                        int oldPoints = int.Parse(line);
                        points += oldPoints;
                        k += 1;
                    }
                }
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

    public static Goal CreateGoal(List<string> goalTypes)
    {
        Console.WriteLine("The types of goals are: ");
        int i = 1;
        foreach (string type in goalTypes)
        {
            Console.WriteLine($"  {i}. {type}");
            i++;
        }

        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        string goalDesc = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string almostPoints = Console.ReadLine();
        int goalPoints = int.Parse(almostPoints);

        if (goalType == "1")
        {
            SimpleGoal newGoal = new SimpleGoal(goalName, goalDesc, goalPoints);
            return newGoal;
        }
        else if (goalType == "2")
        {
            EternalGoal newGoal = new EternalGoal(goalName, goalDesc, goalPoints);
            return newGoal;
        }
        else
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string almostAmount = Console.ReadLine();
            int goalAmount = int.Parse(almostAmount);

            Console.Write("What is the bonus for accomplishing it that number of times? ");
            string almostBonus = Console.ReadLine();
            int goalBonus = int.Parse(almostBonus);

            ChecklistGoal newGoal = new ChecklistGoal(goalName, goalDesc, goalPoints, goalBonus, goalAmount, 0);
            return newGoal;
        }
    }
    public static void DisplayGoals(List<Goal> goalsList)
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        foreach (Goal goal in goalsList)
        {
            Console.Write($"  {i}. ");
            goal.DisplayInformation();
            i++;
        }
        Console.Write("Press enter to continue. ");
        Console.ReadLine();
    }
    public static int RecordEvent(List<Goal> goalsList)
    {
        Console.WriteLine("The goals are: ");
        int i = 1;

        List<Goal> notCompletedGoals = new List<Goal>();

        foreach (Goal goal in goalsList)
        {
            if (goal.GetStatus() == false)
            {
                Console.WriteLine($"  {i}. {goal.GetName()}");
                notCompletedGoals.Add(goal);
                i++;
            }
        }
        if (notCompletedGoals.Count != 0)
        {
            Console.Write("Which goal did you accomplish? ");
            string almostAccomplished = Console.ReadLine();
            int goalAccomplished = int.Parse(almostAccomplished);
            
            Console.WriteLine();
            int points = notCompletedGoals[goalAccomplished - 1].MarkComplete();
            Console.WriteLine($"Congratulations! You have earned {points} points! ");

            return points;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("There are currently no events to record. Please add a goal. ");

            return 0;
        }
    }
    public static void SaveGoals(List<Goal> goalsList, int points)
    {
        Console.Write("Which file would you like to save to? ");
        string filename = Console.ReadLine();
        Console.Write("Saving");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach (Goal goal in goalsList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine();
        Console.Write("Saving Complete! Press enter to continue. ");
        Console.ReadLine();
    }
}