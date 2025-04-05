public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int duration) : base("Listing", "Helps you list as many things as you can in a certain area.", duration) { }

    public override void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        int count = items.Count;

        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
        ShowSpinner(3);
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        return responses;
    }
}