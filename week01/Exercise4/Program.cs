using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        double sum = 0;
        double average = 0;
        int largest = 0;

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
                sum += number;

                if (number > largest)
                {
                    largest = number;
                }
            }
            else
            {
                if (numbers.Count > 0)
                {
                    average = sum / numbers.Count;
                }

                Console.WriteLine($"The sum is {sum};");
                Console.WriteLine($"The average is {average:F6}.");
                Console.WriteLine($"The largest number is {largest}.");
                Console.WriteLine("Program terminated.");
                break;
            }
        }
    }
}
