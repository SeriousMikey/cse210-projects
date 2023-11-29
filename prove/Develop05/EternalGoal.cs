public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points){}

    public override void DisplayInformation()
    {
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()})");
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal::{GetName()}::{GetDescription()}::{GetPoints()}::{GetStatus()}";
    }

    public override int MarkComplete()
    {
        return GetPoints();
    }
}