public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int points) : base(name, desc, points){}

    public override void DisplayInformation()
    {
        if (GetStatus() == false)
        {
            Console.Write("[ ] ");
        }
        else
        {
            Console.Write("[X] ");
        }
        Console.WriteLine($"{GetName()} ({GetDescription()})");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal::{GetName()}::{GetDescription()}::{GetPoints()}::{GetStatus()}";
    }
}