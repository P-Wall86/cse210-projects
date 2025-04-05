public class VisualizationActivity : Activity
{
    private List<string> _scenes = new List<string>()
    {
        "Imagine you're walking through a peaceful forest. The leaves rustle softly with the breeze.",
        "Visualize sitting by a calm lake. The water is perfectly still. You can hear distant birds singing.",
        "Picture yourself reaching a mountain peak after a long climb. Feel the wind, the view, the quiet.",
        "Imagine lying in a warm field under a night sky filled with stars. You feel safe and small in a vast universe.",
        "Visualize stepping into a warm sunbeam after a rainy day. It lights up your face and lifts your spirit."
    };
    public VisualizationActivity(int duration)
        : base("Visualization", "Guides you through calming and empowering visual scenarios to promote relaxation and mental clarity.", duration) {}
    public override void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Get ready to relax and visualize...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Random rnd = new Random();

        while (DateTime.Now < endTime)
        {
            string scene = _scenes[rnd.Next(_scenes.Count)];
            Console.WriteLine();
            Console.WriteLine(scene);
            ShowSpinner(6);
        }
    }
}