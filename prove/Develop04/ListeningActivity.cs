public class ListeningActivity : Activity
{
    private int _count;

    public ListeningActivity(string name, string description) : base(name, description)
    {
        _count = 0;
    }

    public void Run()
    {
        GetReady();

        Console.Write("Close your eyes and listen to your surroundings... ");
        ShowSpinner(GetDuration());
        
        Console.Clear();
        Console.WriteLine("List as many sounds as you heard. Enter 'done' to stop at any time. ");
        string userInput = "";

        do
        {
            Console.Write("> ");
            userInput = Console.ReadLine();
            _count++;
        } while (userInput != "done");

        Console.WriteLine($"You heard {_count - 1} sounds! ");
    }
}