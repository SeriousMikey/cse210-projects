public class PushPullLegs : Routine
{
    private List<string> _pushRoutine = new List<string>();
    private List<string> _pullRoutine = new List<string>();
    private List<string> _legsRoutine = new List<string>();

    public override List<String> CustomRoutine(List<Exercise> exerciseAreas)
    {
        string userChoice;
        Console.WriteLine("Choose an exercise to add to the Push routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetPushRoutine().Add(newExercise);
            Console.Write("Would you like to add another exercise? (yes/no) ");
            userChoice = Console.ReadLine();
        } while (userChoice == "yes");

        Console.WriteLine("Choose an exercise to add to the Pull routine. ");
        do
        {
            string newExercise = GetExerciseCustom(exerciseAreas);
            GetPullRoutine().Add(newExercise);
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
        Console.Write("Random Routine is unavailable for this workout method");
        return GetRoutine();
    }

    public List<String> GetPushRoutine()
    {
        return _pushRoutine;
    }

    public List<String> GetPullRoutine()
    {
        return _pullRoutine;
    }

    public List<String> GetLegsRoutine()
    {
        return _legsRoutine;
    }

    public override void ViewRoutine()
    {
        int i = 1;
        Console.WriteLine("Push Routine: ");
        foreach (String exercise in GetPushRoutine())
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
        i = 1;
        Console.WriteLine("Pull Routine: ");
        foreach (String exercise in GetPullRoutine())
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