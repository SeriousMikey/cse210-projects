public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _amountCompleted;
    private int _amountToComplete;

    public ChecklistGoal(string name, string desc, int points, int bonusPoints, int amountToComplete, int amountCompleted) : base(name, desc, points)
    {
        _bonusPoints = bonusPoints;
        _amountToComplete = amountToComplete;
        _amountCompleted = amountCompleted;
    }

    public override int MarkComplete()
    {
        _amountCompleted += 1;
        if (_amountCompleted >= _amountToComplete)
        {
            SetStatus();
            int points = GetPoints();
            points += _bonusPoints;
            _amountCompleted = _amountToComplete;
            return points;
        }
        return GetPoints();
    }

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
        Console.WriteLine($"{GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_amountToComplete}");
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal::{GetName()}::{GetDescription()}::{GetPoints()}::{GetStatus()}::{_bonusPoints}::{_amountToComplete}::{_amountCompleted}";
    }
}