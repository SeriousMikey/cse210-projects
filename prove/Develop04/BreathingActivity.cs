public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description){}

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;

        GetReady();

        Console.WriteLine();
        Console.Write("Breathe in...");
        ShowCountdown(2);
        Console.WriteLine();
        Console.Write("Now breathe out...");
        ShowCountdown(3);

        do
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountdown(6);
            currentTime = DateTime.Now;
        } while (currentTime < endTime);
        
    }
}