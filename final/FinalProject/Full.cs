public class Full : Routine
{
    public override List<string> CustomRoutine(List<Exercise> exerciseAreas)
    {
        string userChoice;
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();
        
        return GetRoutine();
    }

    public override List<string> RandomRoutine(List<Exercise> exerciseAreas)
    {
        // doesn't add to the routine
        Console.Write("How many exercises would you like to add? ");
        string userChoice = Console.ReadLine();
        int exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {
            Random randomNumberGenerator = new Random();
            int randomNumberOne = randomNumberGenerator.Next(1,6);

            string newExercise = GetExerciseRandom(exerciseAreas, randomNumberOne);
            GetRoutine().Add(newExercise);
            
        }
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();

        return GetRoutine();
    }

    public override void ViewRoutine()
    {
        int i = 1;
        Console.WriteLine("Full Body Routine: ");
        foreach (String exercise in GetRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
    }
}