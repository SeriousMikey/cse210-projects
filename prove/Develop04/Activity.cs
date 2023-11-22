public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }

    public void StartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine();
        Console.WriteLine($"{_activityDescription}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session for? ");
        string almostDuration = Console.ReadLine();
        _duration = int.Parse(almostDuration);
    }

    public void EndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationList = new List<string>() 
        {
            "|",
            "/",
            "-",
            "\\",
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationList[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animationList.Count)
            {
                i = 0;
            }
        }
        
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }
}