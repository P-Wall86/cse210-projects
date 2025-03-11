using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        string letter = "";
        string article = "";
        string symbol = "";

        Console.Write("What is your grade percentage?: ");
        int percentage = int.Parse(Console.ReadLine());

        int lastDigit = percentage % 10;

        //-----------------------------------------------------------------
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Stretch #1
        if (lastDigit >= 7)
        {
            symbol = "+";
        }
        else if (lastDigit > 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

        //Stretches #2 & #3
        if (letter == "A")
        {
            if (lastDigit < 3)
            {
                symbol = "-";
            }
            else
            {
                symbol = "";
            }
            article = "an";
            Console.WriteLine($"You got {article} {letter}{symbol}");
        }
        else if (letter == "F")
        {
            article = "an";
            Console.WriteLine($"You got {article} {letter}");
        }
        else
        {
            article = "a";
            Console.WriteLine($"You got {article} {letter}{symbol}");
        }

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.Write("Congrats. You passed!");
        }
        else if (letter == "D")
        {
            Console.Write("Consider revising your notes. Tutors are available for free.");
        }
        else
        {
            Console.Write("Consider studying harder. Tutors are available for free.");
        }
    }
}