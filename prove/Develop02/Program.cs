using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;


// To exceed minimal requirments, I added the ability to Configure Prompts. This allows the user to View, Add, Delete, 
// and Restore Defaults. They can also save the customized prompts along with the entries.

class Program
{
    static void Main(string[] args)
    {
        int number;
        
        List<Write> entries = new List<Write>();

        Prompt newPrompts = new Prompt();
        // Creating the SaveAndLoadFile instance
        SaveAndLoadFile newFile = new SaveAndLoadFile();
        newFile._listName = entries;
        newFile._promptsList = newPrompts._editedPrompts;
        newFile._promptsList = new List<string>() {"What was the most memorable part of the day?", 
                                                    "What is something that I am proud of today?", 
                                                    "What is something that I could do better in the future?", 
                                                    "What did I do that made someone smile today?", 
                                                    "What is a challenge that I overcame today?"};
        newPrompts._editedPrompts = newFile._promptsList;
        do {
            List<string> options = new List<string>() {"1. Write Entry", 
                                                        "2. Display Journal", 
                                                        "3. Save Journal", 
                                                        "4. Load Journal", 
                                                        "5. Configure Prompts",
                                                        "6. Quit"};
            Console.WriteLine("What would you like to do? ");
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }
            string userChoice = Console.ReadLine();
            number = int.Parse(userChoice);

            // Creating the Write instance
            Write newEntry = new Write();
            
            // Write Entry
            if (number == 1)
            {
                WriteEntry(newEntry, entries, newPrompts._editedPrompts);
            }
            // Display Entries
            else if (number == 2)
            {
                DisplayJournal(entries);
            }
            // Save Journal
            else if (number == 3)
            {
                SaveJournal(newFile);
            }
            // Load Journal
            else if (number == 4)
            {
                LoadJournal(newFile);
            }
            // Configure Prompts
            else if (number == 5)
            {
                newPrompts._editedPrompts = ConfigurePrompts(newPrompts._defaultPrompts, newPrompts, newFile._promptsList);
            }
            // Quit
            else if (number == 6)
            {
                Console.WriteLine("See you next time!");
            }
        } while (number != 6);
    }

    static void WriteEntry(Write newEntry, List<Write> entries, List<string> prompts) {
        
                // Getting the random prompt
                Random rnd = new Random();
                int promptNumber = rnd.Next(0,prompts.Count());

                newEntry._prompt = prompts[promptNumber];

                Console.WriteLine(newEntry._prompt);

                // Getting the user's response
                Console.Write("> ");
                newEntry._response = Console.ReadLine();
                
                // Getting the date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;
                
                // Adding the entry to the list
                entries.Add(newEntry);
    }

    static void DisplayJournal(List<Write> entries)
    {
        // Displaying each entry
                foreach (Write entry in entries)
                {
                    entry.Display();
                }
    }

    static void SaveJournal(SaveAndLoadFile newFile)
    {
        // Getting the file name
                Console.Write("Which file would you like to save this as? ");
                newFile._fileName = Console.ReadLine();
                
                // Running the Save method
                newFile.Save(newFile._listName);
    }

    static void LoadJournal(SaveAndLoadFile newFile)
    {
        // Getting the file name
                Console.Write("Which file would you like to load? ");
                newFile._fileName = Console.ReadLine();

                // Running the Load method
                newFile.Load(newFile._listName, newFile._promptsList);

    }

    static List<string> ConfigurePrompts(List<string> defaultPrompts, Prompt newPrompts, List<string> loadedPrompts)
    {
        List<string> promptOptions = new List<string>() {"1. View Prompts", 
                                                            "2. Add Prompts", 
                                                            "3. Delete Prompts", 
                                                            "4. Restore Default Prompts", 
                                                            "5. Main Menu"};

        List<string> editedPrompts = loadedPrompts;

        int number;

        do {
            Console.WriteLine("What would you like to do? ");
                foreach (string option in promptOptions)
                {
                    Console.WriteLine(option);
                }

            string userChoice = Console.ReadLine();
            number = int.Parse(userChoice);

            if (number == 1)
            {
                newPrompts.ViewPrompts(editedPrompts);
            }
            else if (number == 2)
            {
                editedPrompts = newPrompts.AddPrompts(editedPrompts);
            }
            else if (number == 3)
            {
                editedPrompts = newPrompts.DeletePrompts(editedPrompts);
            }
            else if (number == 4)
            {
                editedPrompts.Clear();
                List<string> defaultList = new List<string>() {"What was the most memorable part of the day?", 
                                                    "What is something that I am proud of today?", 
                                                    "What is something that I could do better in the future?", 
                                                    "What did I do that made someone smile today?", 
                                                    "What is a challenge that I overcame today?"};
                editedPrompts = defaultList;
            }
            else if (number == 5)
            {
                Console.WriteLine("Returning to Main Menu...");
            }
        } while (number != 5);
        return editedPrompts;
    }
}