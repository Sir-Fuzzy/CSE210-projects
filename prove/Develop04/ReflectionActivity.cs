using System;
using System.Runtime.CompilerServices;


public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>{"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    
    public ReflectionActivity(string name, string description) : base(name, description)
    {
    
    }


    public void Run()
    {
        Console.WriteLine("Consider the following:");
        Console.WriteLine("\n----"+GetRandomPrompt()+"----\n");
        Console.WriteLine("When you're ready, press ENTER.");
        Console.Read();

        Console.WriteLine("Now ponder on the following: ");
        Console.Write("Starting in: ");
        base.ShowCountdownTimer(5);
        Console.Clear();
        Console.Write(">>"+GetRandomQuestion());
        base.ShowSpinner(15);
        Console.Write("\n>>"+GetRandomQuestion());
        base.ShowSpinner(15);

        Console.Write("\nMmmm... There! Wasn't that nice? ");
        base.ShowSpinner(5);

        base._duration = 30;

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }
}