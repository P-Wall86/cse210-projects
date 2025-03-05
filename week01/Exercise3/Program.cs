using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();
    
    string playAgain;
    
    do 
    {
        Random random = new Random();
        int number = random.Next(0, 101);
        int guessCount = 0; //Stretch #1
        Console.WriteLine("What is the magic number?");

        int guess;

        do 
        {
        
            Console.Write("Pick a number: ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;
            Console.WriteLine();

            if (guess == number)
            {
                Console.WriteLine($"You guessed it! It's {number}!");
                Console.WriteLine($"It took you {guessCount} tries to get the right number.");
                break;
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower. Try again!");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher. Try again!");
            }
        }  while (true);  

        Console.WriteLine();
        Console.WriteLine("Do you want to play again? (y/n)");
        playAgain = Console.ReadLine().ToLower();  

    } while (playAgain == "y"); //Stretch #2

    Console.WriteLine("Goodbye!");
    }
}