public class ListingActivity : Activity
{
    private List<string> _promptList;
    private int _count;
    public ListingActivity(string name, string description, List<string> promptList) : base(name, description)
    {
        _promptList = promptList;
        _count = 0;
    }

    public void Run()
    {
        Console.Clear();

        GetReady();
        DisplayPrompt();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;

        do
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        } while (currentTime < endTime);

        Console.WriteLine($"You listed {_count} items! ");
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, _promptList.Count);
        return _promptList[randomNumber];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
    }
}