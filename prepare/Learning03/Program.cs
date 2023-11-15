using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction newFraction = new Fraction(5, 10);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
        newFraction.SetBottom(20);
        Console.WriteLine(newFraction.GetFractionString());
        Console.WriteLine(newFraction.GetDecimalValue());
        newFraction.GetTop();
    }
}