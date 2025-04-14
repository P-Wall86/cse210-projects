using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("2025-04-14", 30, 4.8),
            new Cycling("2025-04-14", 45, 20.0),
            new Swimming("2025-04-14", 30, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}