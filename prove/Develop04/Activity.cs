using System;

public class Activity
{

    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }



    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welocme to the {_name} activity.\n");
        Console.WriteLine(_description);
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nThank you for choosing to Meditate with BlackInc. Meditations(C)");
        Console.WriteLine($"You have just completed the {_name} for {_duration} seconds.");
        Console.WriteLine("Enjoy a more relaxed life.");

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> spinner = new List<string>();
        spinner.Add("-");
        spinner.Add("+");
        spinner.Add("|");
        spinner.Add("+");


        int i = 0;

        while (DateTime.Now <= endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }   
        }

        _duration = seconds;
    }

    public void ShowCountdownTimer(int seconds)
    {
        int time = seconds;
        for (int i = time; i > 0; i--)
        {
            Console.Write(time);
            time --;
            Thread.Sleep(1000);
            Console.Write("\b  \b\b");
        }

        _duration = seconds;

    }
}