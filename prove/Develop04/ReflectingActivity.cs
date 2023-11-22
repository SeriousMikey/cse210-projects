public class ReflectingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _reflectionQuestions;
    public ReflectingActivity(string name, string description, List<string> promptList, List<string> reflectionQuestions) : base(name, description)
    {
        _promptList = promptList;
        _reflectionQuestions = reflectionQuestions;
    }

    public void Run()
    {
        GetReady();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        Console.Clear();

        do
        {
            DisplayQuestions();
            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _promptList.Count);
        return _promptList[randomNumber];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _reflectionQuestions.Count);
        return _reflectionQuestions[randomNumber];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(15);
        Console.WriteLine();
    }
}