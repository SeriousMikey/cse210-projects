using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input a grade percentage: ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        if (grade >=70)
        {
            Console.WriteLine("You passed!!!");
        }
        else 
        {
            Console.WriteLine("Sorry, try again next time.");
        }
    }
}