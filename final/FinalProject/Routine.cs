using System.ComponentModel;

public abstract class Routine
{
    private List<String> _routine = new List<string>();

    public abstract List<string> CustomRoutine(List<Exercise> exerciseAreas);

    public abstract List<string> RandomRoutine(List<Exercise> exerciseAreas);

    public string GetExerciseCustom(List<Exercise> exerciseAreas)
    {
        List<string> exercises = new List<string>();
        Exercise arms = exerciseAreas[0];
        Exercise chest = exerciseAreas[1];
        Exercise core = exerciseAreas[2];
        Exercise back = exerciseAreas[3];
        Exercise legs = exerciseAreas[4];

        Console.WriteLine("1. Arms");
        Console.WriteLine("2. Chest");
        Console.WriteLine("3. Core");
        Console.WriteLine("4. Back");
        Console.WriteLine("5. Legs");
        Console.Write("Choose an area: ");
        string userChoice = Console.ReadLine();
        Console.Clear();

        if (userChoice == "1")
        {
            arms.ViewList();
            exercises = arms.GetList();
        }
        else if (userChoice == "2")
        {
            chest.ViewList();
            exercises = chest.GetList();
        }
        else if (userChoice == "3")
        {
            core.ViewList();
            exercises = core.GetList();
        }
        else if (userChoice == "4")
        {
            back.ViewList();
            exercises = back.GetList();
        }
        else if (userChoice == "5")
        {
            legs.ViewList();
            exercises = legs.GetList();
        }
        
        Console.Write("Which exercise would you like to add to your routine? ");
        userChoice = Console.ReadLine();
        int exerciseNumber = int.Parse(userChoice);
        string newExercise = exercises[exerciseNumber - 1];

        return newExercise;
    }

    public string GetExerciseRandom(List<Exercise> exerciseAreas, int randomNumberOne)
    {
        List<string> exercises = new List<string>();
        Exercise arms = exerciseAreas[0];
        Exercise chest = exerciseAreas[1];
        Exercise core = exerciseAreas[2];
        Exercise back = exerciseAreas[3];
        Exercise legs = exerciseAreas[4];

        if (randomNumberOne == 1)
        {
            arms.ViewList();
            exercises = arms.GetList();
        }
        else if (randomNumberOne == 2)
        {
            chest.ViewList();
            exercises = chest.GetList();
        }
        else if (randomNumberOne == 3)
        {
            core.ViewList();
            exercises = core.GetList();
        }
        else if (randomNumberOne == 4)
        {
            back.ViewList();
            exercises = back.GetList();
        }
        else if (randomNumberOne == 5)
        {
            legs.ViewList();
            exercises = legs.GetList();
        }
        Random randomNumberGenerator = new Random();
        int exerciseNumber = exercises.Count();
        int randomNumberTwo = randomNumberGenerator.Next(exerciseNumber);
        string newExercise = exercises[randomNumberTwo];

        return newExercise;
    }

    public virtual List<String> GetRoutine()
    {
        return _routine;
    }

    public abstract void ViewRoutine();

    public virtual List<string> CreateRoutine(List<Exercise> exerciseAreas)
    {
        Console.Clear();
        List<string> newRoutine = new List<string>();
        Console.WriteLine("Would you like to create a: ");
        Console.WriteLine("1. Custom Routine");
        Console.WriteLine("2. Random Routine");
        string userChoice = Console.ReadLine();
        
        if (userChoice == "1")
        {
            newRoutine = CustomRoutine(exerciseAreas);
        }
        else if (userChoice == "2")
        {
            newRoutine = RandomRoutine(exerciseAreas);
        }

        return newRoutine;
    }
}