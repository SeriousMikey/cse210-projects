using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Globalization;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        int routineType = 0;

        List<string> routine = new List<string>()
        {
            "Nothing to see here..."
        };

        List<string> mainMenu = new List<string>()
        {
            "View Current Routine",
            "New Routine",
            "View Workout Tip",
            "Edit Exercises",
            "Save Data",
            "Load Data",
            "Quit"
        };
        List<string> routineMenu = new List<string>()
        {
            "Full Body",
            "Upper/Lower Body Split",
            "Push/Pull/Legs Split",
            "Bro Split"
        };
        List<string> exerciseTips = new List<string>()
        {
            "Take a moment to just breathe",
            "Hype yourself up",
            "Put on pump-up music",
            "Eliminate distractions",
            "Have a clear plan",
            "Be flexible",
            "Literally tap the muscle you're using",
            "Make sure you're not too hungry",
            "Keep things simple",
            "Not every workout needs to leave you exhausted"
        };

        List<string> armsExercises = new List<string>()
        {
            "EZ-Bar Curl",
            "Concentration Curl",
            "Hammer Curl",
            "Cable Curl",
            "Chin-Up",
            "Dumbbell Skull Crusher",
            "Dip",
            "JM Press",
            "Triceps Pushdown",
            "Triceps Kickback"
        };
        List<string> chestExercises = new List<string>()
        {
            "Barbell Bench Press",
            "Dumbbell Bench Press",
            "Incline Bench Press",
            "Decline Press",
            "Machine Chest Press",
            "Push-Up",
            "Dip",
            "Chest Fly",
            "Dumbbell Pull-Over",
            "Machine Fly"
        };
        List<string> coreExercises = new List<string>()
        {
            "Bridge",
            "Crunch",
            "Supine Toe Tap",
            "Bird Dog",
            "Bycicle Crunch",
            "Plank",
            "Warrior Crunch",
            "Mountain Climber",
            "Side Plank with Rotation",
            "Bird Dog with Elbow to Knee"
        };
        List<string> backExercises = new List<string>()
        {
            "Deadlift",
            "Bent-Over Row",
            "Pull-Up",
            "T-Bar Row",
            "Seated Row",
            "Single-Arm Smith Machine Row",
            "Lat Pull-Down",
            "Single-Arm Dumbbell Row",
            "Dumbbell Pull-Over",
            "Chest-Supported Row"
        };
        List<string> legsExercises = new List<string>()
        {
            "Squat",
            "Leg Press",
            "Hack Squat",
            "Bulgarian Split Squat",
            "Romanian Deadlift",
            "Stiff-Legged Deadlift",
            "Leg Extension",
            "Seated Leg Curl",
            "Lying Leg Curl",
            "Standing Calf Raise"
        };

        Arms arms = new Arms(armsExercises);
        Chest chest = new Chest(chestExercises);
        Core core = new Core(coreExercises);
        Back back = new Back(backExercises);
        Legs legs = new Legs(legsExercises);

        List<Exercise> exerciseAreas = new List<Exercise>(){arms, chest, core, back, legs};
        
        do
        {
            Console.Clear();
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
                Console.Clear();
                if (routineType == 1)
                {
                    
                }
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }

            else if (userChoice == "2")
            {
                Console.Clear();
                i = 1;
                foreach (string option in routineMenu)
                {
                    Console.WriteLine($"  {i}. {option}");
                    i++;
                }
                Console.Write("Select a choice from the menu: ");
                userChoice = Console.ReadLine();
                
                if (userChoice == "1")
                {
                    Full full = new Full();
                    routine = full.CreateRoutine(exerciseAreas);
                    routineType = 1;
                }
                else if (userChoice == "2")
                {
                    UpperLower upperLower = new UpperLower();
                    routine = upperLower.CreateRoutine(exerciseAreas);
                    routineType = 2;
                }
                else if (userChoice == "3")
                {
                    PushPullLegs pushPullLegs = new PushPullLegs();
                    routine = pushPullLegs.CreateRoutine(exerciseAreas);
                    routineType = 3;
                }
                else if (userChoice == "4")
                {
                    BroSplit broSplit = new BroSplit();
                    routine = broSplit.CreateRoutine(exerciseAreas);
                    routineType = 4;
                }
            }

            else if (userChoice == "3")
            {
                Console.Clear();
                Random randomNumberGenerator = new Random();
                int randomNumber = randomNumberGenerator.Next(exerciseTips.Count());
                Console.WriteLine(exerciseTips[randomNumber]);
                Console.Write("Press enter to continue. ");
                Console.ReadLine();
            }

            else if (userChoice == "4")
            {
                Console.Clear();
                i = 1;
                foreach (Exercise exercise in exerciseAreas)
                {
                    Console.WriteLine($"{i}. {exercise}");
                    i++;
                }
                Console.Write("Which list would you like to edit? ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    arms.EditList();
                }
                else if (userChoice == "2")
                {
                    chest.EditList();
                }
                else if (userChoice == "3")
                {
                    core.EditList();
                }
                else if (userChoice == "4")
                {
                    back.EditList();
                }
                else if (userChoice == "5")
                {
                    legs.EditList();
                }
            }

            else if (userChoice == "5")
            {
                // Figure out if backspace works
                Console.Clear();
                Console.Write("Which file would you like to save to? ");
                string filename = Console.ReadLine();
                Console.Write("Saving");
                for (i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.Write("0::");
                    int amount = routine.Count();
                    outputFile.Write($"{amount}::");
                    foreach (string routineMember in routine)
                    {
                        outputFile.Write($"{routineMember}::");
                    }
                    outputFile.Write("\b\b");
                    outputFile.WriteLine();
                    i = 1;
                    foreach (Exercise area in exerciseAreas)
                    {
                        outputFile.Write($"{i}::");
                        amount = area.GetList().Count();
                        outputFile.Write($"{amount}");
                        foreach (string exercise in area.GetList())
                        {
                            outputFile.Write($"::{exercise}");
                        }
                        outputFile.WriteLine();
                        i++;
                    }
                }
                Console.WriteLine();
                Console.Write("Saving Complete! Press enter to continue. ");
                Console.ReadLine();
            }

            else if (userChoice == "6")
            {
                
                Console.Clear();
                Console.Write("Which file would you like to load from? ");
                string filename = Console.ReadLine();
                Console.Write("Loading");
                for (int j = 0; j < 3; j++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }

                routine.Clear();
                arms.GetList().Clear();
                chest.GetList().Clear();
                core.GetList().Clear();
                back.GetList().Clear();
                legs.GetList().Clear();
                
                string[] lines = System.IO.File.ReadAllLines(filename);

                int k = 0;

                foreach (string line in lines)
                {
                    string[] parts = line.Split("::");

                    string almostType = parts[0];
                    int type = int.Parse(almostType);

                    string almostLength = parts[1];
                    int length = int.Parse(almostLength);

                    for (i = 2; i < length + 2; i++)
                    {
                        if (type == 0)
                        {
                            routine.Add(parts[i]);
                        }
                        else if (type == 1)
                        {
                            arms.AddToList(parts[i]);
                        }
                        else if (type == 2)
                        {
                            chest.AddToList(parts[i]);
                        }
                        else if (type == 3)
                        {
                            core.AddToList(parts[i]);
                        }
                        else if (type == 4)
                        {
                            back.AddToList(parts[i]);
                        }
                        else if (type == 5)
                        {
                            legs.AddToList(parts[i]);
                        }
                    }
                    k++;
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
}