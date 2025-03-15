using System;
using System.Collections.Generic;
using System.IO;

/*I decided to save the entries in a CSV file. I had to do my research about things
I didn't understand: how to use StreamWriter and StreamReader, even though I used just one of them in the Journal.cs file.*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string filePath = "journal.csv";

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("===== Journal Menu =====");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries.");
            Console.WriteLine("4. Load entries.");
            Console.WriteLine("5. Quit");
            Console.WriteLine("\nEnter your choice (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewEntry(myJournal, promptGenerator);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    Console.WriteLine("\nPress any key to go back to the menu...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Write("Enter the filename to save to (e.g., journal.csv): ");
                    filePath = Console.ReadLine();
                    myJournal.SaveToFile(filePath);
                    Console.WriteLine($"Entries saved to {filePath}");
                    Console.WriteLine("\nPress any key to go back to the menu...");
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Write("Enter the filename to load from (e.g., journal.csv): ");
                    string fileToLoad = Console.ReadLine();
                    myJournal.LoadFromFile(fileToLoad);
                    Console.WriteLine("\nJournal loaded successfully!");
                    Console.WriteLine("\nPress any key to go back to the menu...");
                    Console.ReadKey();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        static void AddNewEntry(Journal journal, PromptGenerator promptGenerator)
        {
            string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            string prompt = promptGenerator.GetRandomPrompt();

            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Your entry: ");
            string entryText = Console.ReadLine();

            Entry newEntry = new Entry(date, prompt, entryText);
            journal.AddEntry(newEntry);

            Console.WriteLine("\nEntry added successfully!");
            Console.WriteLine("\nPress any key to go back to the menu...");
            Console.ReadKey();
        }
    }
}