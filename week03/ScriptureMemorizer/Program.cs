using System;
using System.Collections.Generic;
using System.IO;

/* The program loads scriptures from a .txt file. I had to modify the .csproj to ensure the file
    was copied to the output folder and I got so many errors before learning I had to do this. The program reads
    the file, parses the references and display scriptures randomly. It hides three words at a time, but after
    the first hide, it might select a hidden word again. That might be quite annoying, lol. */

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScriptureFromFile("scriptures.txt");

        Random random = new Random();
        Scripture selectedScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (selectedScripture.AllWordsHidden())
                break;

            selectedScripture.HideRandomWords(3);
        }
    }

    static List<Scripture> LoadScriptureFromFile(string filePath)
    {
        string fullPath = Path.GetFullPath(filePath);

        if (!File.Exists(fullPath))
        {
            Console.WriteLine($"File not found at: {fullPath}");
            return new List<Scripture>();
        }
        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            try
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string referenceText = parts[0];
                    string scriptureText = parts[1];

                    Reference reference = ParseReference(referenceText);

                    scriptures.Add(new Scripture(reference, scriptureText));
                }
                else
                {
                    Console.WriteLine($"Invalid line format: '{line}'. Expected format: 'Reference|Scripture Text'.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing line: '{line}'. {ex.Message}");
            }
        }

        return scriptures;
    }

    static Reference ParseReference(string referenceText)
    {
        string[] parts = referenceText.Split(' ');
        string book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);

        if (chapterVerse[1].Contains('-'))
        {
            string[] verses = chapterVerse[1].Split('-');
            int verseStart = int.Parse(verses[0]);
            int verseEnd = int.Parse(verses[1]);
            return new Reference(book, chapter, verseStart, verseEnd);
        }
        else
        {
            int verse = int.Parse(chapterVerse[1]);
            return new Reference(book, chapter, verse);
        }
    }
}