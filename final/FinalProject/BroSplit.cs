public class BroSplit : Routine
{
    private List<string> _armsRoutine = new List<string>();
    private List<string> _chestRoutine = new List<string>();
    private List<string> _coreRoutine = new List<string>();
    private List<string> _backRoutine = new List<string>();
    private List<string> _legsRoutine = new List<string>();

    public override List<String> CustomRoutine(List<Exercise> exerciseAreas)
    {
        string userChoice;
        Console.WriteLine("Choose an exercise to add to the Arms routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetArmsRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Chest routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetChestRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Core routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetCoreRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Back routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetBackRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Legs routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetLegsRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();
        return GetRoutine();
    }

    public override List<String> RandomRoutine(List<Exercise> exerciseAreas)
    {
        Console.Write("How many exercises would you like to add to Arms? ");
        string userChoice = Console.ReadLine();
        int exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {
            Random randomNumberGenerator = new Random();
            int randomNumberOne = randomNumberGenerator.Next(1,5);

            string newExercise = GetExerciseRandom(exerciseAreas, randomNumberOne);
            GetArmsRoutine().Add(newExercise);
        }
        Console.Write("How many exercises would you like to add to Chest? ");
        userChoice = Console.ReadLine();
        exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {

            string newExercise = GetExerciseRandom(exerciseAreas, 5);
            GetChestRoutine().Add(newExercise);
        }
        Console.Write("How many exercises would you like to add to Core? ");
        userChoice = Console.ReadLine();
        exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {

            string newExercise = GetExerciseRandom(exerciseAreas, 5);
            GetCoreRoutine().Add(newExercise);
        }
        Console.Write("How many exercises would you like to add to Back? ");
        userChoice = Console.ReadLine();
        exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {

            string newExercise = GetExerciseRandom(exerciseAreas, 5);
            GetBackRoutine().Add(newExercise);
        }
        Console.Write("How many exercises would you like to add to Legs? ");
        userChoice = Console.ReadLine();
        exerciseNumber = int.Parse(userChoice);
        for (int i = 0; i > exerciseNumber; i++)
        {

            string newExercise = GetExerciseRandom(exerciseAreas, 5);
            GetLegsRoutine().Add(newExercise);
        }
        Console.WriteLine("Routine Completed! Press Enter to continue");
        Console.ReadLine();
        return GetRoutine();
    }

    public List<String> GetArmsRoutine()
    {
        return _armsRoutine;
    }

    public List<String> GetChestRoutine()
    {
        return _chestRoutine;
    }

    public List<String> GetCoreRoutine()
    {
        return _coreRoutine;
    }

    public List<String> GetBackRoutine()
    {
        return _backRoutine;
    }

    public List<String> GetLegsRoutine()
    {
        return _legsRoutine;
    }

    public override void ViewRoutine()
    {
        int i = 1;
        Console.WriteLine("Arms Routine: ");
        foreach (String exercise in GetArmsRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Chest Routine: ");
        foreach (String exercise in GetChestRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Core Routine: ");
        foreach (String exercise in GetCoreRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Back Routine: ");
        foreach (String exercise in GetBackRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Legs Routine: ");
        foreach (String exercise in GetLegsRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
    }
}