using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Random rand = new Random();
                    string prompt = prompts[rand.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    myJournal.AddEntry(prompt, response, date);
                    Console.WriteLine("Entry recorded.\n");
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.\n");
                    break;
            }
        }
    }
}
