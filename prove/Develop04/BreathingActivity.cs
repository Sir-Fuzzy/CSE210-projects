using System;


public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    

    public void Run(int seconds)
    {
        int totalTime = 0;
        
        Console.Clear();
        Console.WriteLine("Are you ready?");
        Thread.Sleep(1000);


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now <= endTime)
        {
            Console.Write("\n\nBreath in...");
            ShowCountdownTimer(5);
            totalTime += 5;
            Console.Write("\nAnd out...");
            ShowCountdownTimer(3);
            totalTime +=3;
        }

        base._duration = totalTime;
    }
}