public class UpperLower : Routine
{
    private List<string> _upperRoutine = new List<string>();
    private List<string> _lowerRoutine = new List<string>();

    public override List<string> CustomRoutine(List<Exercise> exerciseAreas)
    {
        string userChoice;
        Console.WriteLine("Choose an exercise to add to the Upper Body routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetUpperRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Lower Body routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetLowerRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();
        return GetRoutine();
    }

    public override List<string> RandomRoutine(List<Exercise> exerciseAreas)
    {
        Console.Write("How many exercises would you like to add to Upper Body? ");
        string userChoice = Console.ReadLine();
        int exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {
            Random randomNumberGenerator = new Random();
            int randomNumberOne = randomNumberGenerator.Next(1,5);

            string newExercise = GetExerciseRandom(exerciseAreas, randomNumberOne);
            GetRoutine().Add(newExercise);
        }
        Console.Write("How many exercises would you like to add to Lower Body? ");
        userChoice = Console.ReadLine();
        exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {

            string newExercise = GetExerciseRandom(exerciseAreas, 5);
            GetRoutine().Add(newExercise);
        }
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();
        return GetRoutine();
    }

    public List<String> GetUpperRoutine()
    {
        return _upperRoutine;
    }

    public List<String> GetLowerRoutine()
    {
        return _lowerRoutine;
    }

    public override void ViewRoutine()
    {
        int i = 1;
        Console.WriteLine("Upper Body Routine: ");
        foreach (String exercise in GetUpperRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Lower Body Routine: ");
        foreach (String exercise in GetLowerRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
    }
}