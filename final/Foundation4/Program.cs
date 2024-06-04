using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("01 March 2024", 17, 2.3);

        Biking biking = new Biking("13 May 2024", 132, 20.6);

        Swimming swimming = new Swimming("22 June 2024", 32, 8);

        List<Activity> activities = new List<Activity>{running, biking, swimming};

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}