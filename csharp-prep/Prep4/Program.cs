using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        int sumNumbers = 0;
        int bigNumber = 0;

        Console.WriteLine("Please enter a list of numbers. Type 0 when finished. ");
        do
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            if (number != 0)
            {
                numbers.Add(number);

                sumNumbers += number;

                if (number > bigNumber)
                {
                    bigNumber = number;
                }
        }

        } while (number != 0);

        int listSize = numbers.Count;
        float averageNumbers = (float)sumNumbers / listSize;

        Console.WriteLine($"The sum is: {sumNumbers}");
        Console.WriteLine($"The average is: {averageNumbers}");
        Console.WriteLine($"The largest number is: {bigNumber}");
    }
}