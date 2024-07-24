using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Adding different activities
        activities.Add(new Cycling
        {
            ActivityDate = DateTime.Now,
            Duration = 60,
            Distance = 20,
            Speed = 20,
            Pace = 3
        });

        activities.Add(new Running
        {
            ActivityDate = DateTime.Now,
            Duration = 45,
            Distance = 10,
            Speed = 13,
            Pace = 4.5
        });

        activities.Add(new Swimming
        {
            ActivityDate = DateTime.Now,
            Duration = 30,
            Distance = 2,
            Speed = 4,
            Pace = 15
        });

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.ActivitySummary());
        }
    }
}
