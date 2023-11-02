using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int guessAmount = 0;

            bool correct = false;
            do {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                int guess = int.Parse(userGuess);

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    guessAmount++;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    guessAmount++;
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                    Console.WriteLine($"You guessed {guessAmount} times! ");
                    correct = true;
                }
            } while (correct == false);
            Console.Write("Would you like to play again? (yes/no) ");
            response = Console.ReadLine();
        }
    }
}