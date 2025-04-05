public class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base("Breathing", "Helps you relax through paced breathing. Clear your mind and focus on your breathing.", duration) { }
    public override void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready...");
        ShowSpinner(10);

        int timePassed = 0;
        while (timePassed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(5);
            timePassed += 10;
        }
    }
}