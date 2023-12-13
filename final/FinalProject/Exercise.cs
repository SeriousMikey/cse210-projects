public class Exercise
{
    private List<String> _exercises = new List<String>(); 

    public Exercise(List<String> exercises)
    {
        _exercises = exercises;
    }
    
    public void ViewList()
    {
        List<String> exerciseList = GetList();
        int i = 1;
        foreach (String exercise in exerciseList)
        {
            Console.WriteLine($"{i}. {exercise}");
            i++;
        }
    }

    public void AddToList(string newExercise)
    {
        List<String> exerciseList = GetList();
        exerciseList.Add(newExercise);
    }

    public void RemoveFromList(int listNumber)
    {
        List<String> exerciseList = GetList();
        int removeNumber = listNumber - 1;
        exerciseList.Remove(exerciseList[removeNumber]);
    }

    public void EditList()
    {
        Console.Clear();
        Console.WriteLine("Would you like to: ");
        Console.WriteLine("1. Add an exercise to the list");
        Console.WriteLine("2. Remove an exercise from the list");
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Console.Write("What is the name of the exercise? ");
            string newExercise = Console.ReadLine();
            AddToList(newExercise);
            Console.Write("Successfully added to the list! Press Enter to continue. ");
            Console.ReadLine();
        }
        else if (userChoice == "2")
        {
            Console.Clear();
            int i = 1;
            foreach (string exercise in GetList())
            {
                Console.WriteLine($"  {i}. {exercise}");
                i++;
            }
            Console.Write("Select an exercise to remove: ");
            userChoice = Console.ReadLine();
            int removeNumber = int.Parse(userChoice);
            RemoveFromList(removeNumber);
            Console.Write("Successfully removed from the list! Press Enter to continue. ");
            Console.ReadLine();
        }
    }

    public List<String> GetList()
    {
        return _exercises;
    }
}