using System.Threading;
public abstract class Activity
{
    private string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.WriteLine("(Choose wisely—10 seconds won’t do much.)");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
        Console.WriteLine("Take a moment to feel good about your efforts.");
        ShowSpinner(2);
        Console.WriteLine();
    }
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b");
            i = (i + 1) % spinner.Length;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public abstract void Run();
}