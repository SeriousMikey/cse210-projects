using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> menuOptions = new List<string>() {
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Start a listening activity",
            "5. Random activity",
            "6. 10 Minute Challenges",
            "7. Quit"
        };
        int choice = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            foreach (string option in menuOptions)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            choice = int.Parse(menuChoice);

            GetActivity(choice);
            
        } while (choice < 7);
    }

    static void GetActivity(int choice)
    {
        if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", 
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                
                breathingActivity.StartingMessage();
                breathingActivity.Run();
                breathingActivity.EndingMessage();
            }
            else if (choice == 2)
            {
                List<string> promptList = new List<string>()
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                };

                List<string> questionList = new List<string>()
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not as successful?",
                    "What is your favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situations?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };

                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", 
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 
                promptList, questionList);
                
                reflectingActivity.StartingMessage();
                reflectingActivity.Run();
                reflectingActivity.EndingMessage();
            }
            else if (choice == 3)
            {
                List<string> promptList = new List<string>()
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
                };

                ListingActivity listingActivity = new ListingActivity("Listing Activity", 
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
                promptList);

                listingActivity.StartingMessage();
                listingActivity.Run();
                listingActivity.EndingMessage();
            }
            else if (choice == 4)
            {
                ListeningActivity listeningActivity = new ListeningActivity("Listening Activity", "Close your eyes and open your ears. Listen to your surroundings and then list the sounds that you heard. ");
                listeningActivity.StartingMessage();
                listeningActivity.Run();
                listeningActivity.EndingMessage();
            }
            else if (choice == 5)
            {
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(0, 3);
                randomNumber += 1;
                
                GetActivity(randomNumber);
            }
            else if (choice == 6)
            {
                List<string> challengeList = new List<string>()
                {
                    "Meditate for 10 minutes! ",
                    "Go outside and meditiate for 10 minutes! ",
                    "Color for 10 minutes! ",
                    "Listen to music for 10 minutes! ",
                    "Lay down with your eyes closed for 10 minutes! "
                };
                Console.Clear();
                Random randomGenerator = new Random();
                int randomNumber = randomGenerator.Next(0, challengeList.Count);
                Console.WriteLine(challengeList[randomNumber]);
                Console.WriteLine();
                Console.WriteLine("Press enter to go back to the main menu");
                Console.ReadLine();
            }
    }
}