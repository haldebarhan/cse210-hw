using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = [];
        DateTime dateTime = new(2024, 6, 4);
        Running running = new(dateTime, 40, 5.8);
        Cycling cycling = new(dateTime, 30, 6.5);
        Swimming swimming = new(dateTime, 20, 4);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}