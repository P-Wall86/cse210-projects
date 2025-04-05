using System;

/* Stretch: Added VisualizationActivity, a new type of activity that guides the user through peaceful visual scenes.  
   It prompts calming imagery and uses pauses to support relaxation and focus.*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool quit = false;

        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Start visualization activity");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Select a choice for the menu:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity(0);
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity(0);
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity(0);
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;
                case "4":
                    VisualizationActivity visualization = new VisualizationActivity(0);
                    visualization.Run();
                    visualization.DisplayEndingMessage();
                    break;
                case "5":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}