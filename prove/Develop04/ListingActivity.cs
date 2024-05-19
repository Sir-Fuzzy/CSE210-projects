using System;
using System.Diagnostics;


public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>{"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};

    
    public ListingActivity(string name, string description) : base(name, description)
    {
        _count = 0;
    }
    
    public void Run(int seconds)
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        // Stopwatch stopwatch = new Stopwatch();
        // stopwatch.Start();

        var watch = Stopwatch.StartNew();
        
        Console.WriteLine("Enter as many answers you can think of to the following question:");

        Console.WriteLine(GetRandomPrompt());

        while (endTime>DateTime.Now)
        {
            GetListFromUser();
            _count ++;
        }
        
        watch.Stop();
        // stopwatch.Stop();
        // int milliseconds = stopwatch.Elapsed.Milliseconds;
        // base._duration = milliseconds;
        Console.WriteLine($"{watch.Elapsed} ms");
        TimeSpan timeSpan = watch.Elapsed;

        base._duration = timeSpan.Seconds;

        Console.WriteLine($"\n Congrats! You listed {_count} things! Whoopdeedoo!");

    }

    public string GetRandomPrompt()
    {
        
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return "----"+prompt+"----";

    }

    public List<string> GetListFromUser()
    {

        List<string> answers = new List<string>();
        Console.Write(">>");
        string input = Console.ReadLine();
        answers.Add(input);
        return answers;
    }
}