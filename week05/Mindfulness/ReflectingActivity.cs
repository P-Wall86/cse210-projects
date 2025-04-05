public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public ReflectingActivity(int duration) : base("Reflecting", "Helps you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration) { }

    public override void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine();
        DisplayPrompt();
        ShowSpinner(5);

        Console.Clear();
        ShowSpinner(2);
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience:");
        Console.WriteLine();

        int timePassed = 0;
        int questionIndex = 0;

        while (timePassed < _duration)
        {
            if (questionIndex >= _questions.Count)
                questionIndex = 0;

            Console.Write("> ");
            Console.WriteLine(_questions[questionIndex]);
            ShowSpinner(5);
            Console.WriteLine();

            questionIndex++;
            timePassed += 5;
        }
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.Write("> ");
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}