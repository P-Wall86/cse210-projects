using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine();
        DisplayWelcome();
        Console.WriteLine();
        
        string name = PromptUserName();

        int favnum = PromptUserNumber();

        int square = SquareNumber(favnum);
        DisplayResult(name, square);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to CSE 210!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int favnum = int.Parse(Console.ReadLine());
        return favnum;
    }

    static int SquareNumber(int favnum)
    {
        return favnum * favnum;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, your favorite number squared is {square}.");
    }
    }