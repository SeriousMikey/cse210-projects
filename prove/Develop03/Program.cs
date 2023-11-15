using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        
        Scripture scripture = RandomScripture();

        List<Word> wordsList = scripture.GetWordsList();
        Console.Write("How many words would you like to hide at one time? ");
        string userNumber = Console.ReadLine();
        int newNumber = int.Parse(userNumber);
        if (newNumber > wordsList.Count)
        {
            newNumber = wordsList.Count;
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");
        userInput = Console.ReadLine();
        while ( userInput != "quit" && scripture.IsCompletelyHidden() == false)
        {
            int number = 0;
            Console.Clear();
            while (number != newNumber)
            {
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(0, wordsList.Count);
                scripture.HideRandomWords(randomNumber);
                number += 1;
            }
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
        }
    }

    static Scripture RandomScripture()
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(0, 7);

        if (randomNumber == 1)
        {
        Reference reference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";
        Scripture scripture = new Scripture(reference, scriptureText);
        return scripture;
        
        }
        else if (randomNumber == 2)
        {
        Reference reference = new Reference("Romans", 8, 28);
        string scriptureText = "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.";
        Scripture scripture = new Scripture(reference, scriptureText);
        return scripture;
        }
        else if (randomNumber == 3)
        {
        Reference reference = new Reference("Philippians ", 4, 6);
        string scriptureText = "Do not be anxious about anything, but in everything, by prayer and petition, with thanksgiving, present your requests to God.";
        Scripture scripture = new Scripture(reference, scriptureText);
        return scripture;
        }
        else if (randomNumber == 4)
        {
        Reference reference = new Reference("Galatians", 5, 22, 23);
        string scriptureText = "But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control. Against such things there is no law.";
        Scripture scripture = new Scripture(reference, scriptureText);
        return scripture;
        }
        else if (randomNumber == 5)
        {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, scriptureText);
        return scripture;
        }
        else
        {
            Reference reference = new Reference("Hebrews", 11, 6);
            string scriptureText = "And without faith it is impossible to please God, because anyone who comes to him must believe that he exists and that he rewards those who earnestly seek him.";
            Scripture scripture = new Scripture(reference, scriptureText);
            return scripture;
        }
    }
}