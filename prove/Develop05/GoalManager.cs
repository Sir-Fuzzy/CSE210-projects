using System;
using System.Runtime.CompilerServices;
using System.IO;
using System.Text.Json;
using System.Data.Common;
using System.IO.Enumeration;
using System.Xml.Linq;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;


    public GoalManager(){}
    

    public void Start()
    {
        Console.WriteLine("Who is Looking at their goals?");
        string name = Console.ReadLine();
        string fileName = name + ".txt";
        if (File.Exists(fileName))
        {
            LoadGoals(fileName);
        }
        else 
        {
            File.Create(fileName);
        }


        bool keepRunning = true;


        while (keepRunning)
        {

            Console.WriteLine("Menu:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Record Event");
            Console.WriteLine("   5. See Points");
            Console.WriteLine("   0. Quit");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                CreateGoal();
            }
            else if (menuChoice == "2")
            {
                ListGoalDetails();
            }
            else if (menuChoice == "3")
            {
                SaveGoals(fileName);
            }
            else if (menuChoice == "4")
            {
                RecordEvent();
            }
            else if (menuChoice == "5")
            {
                PlayerPointsProgress();
            }
            else if (menuChoice == "0")
            {
                SaveGoals(fileName);
                keepRunning = false;
            }
        }
    }

    public void PlayerPointsProgress()
    {
        foreach (Goal goal in _goals)
        {
            _score += goal.GetTotalPoints();
        }

        Console.WriteLine($"You have {_score} points right now.");
    }

    public void ListGoalDetails()
    {
        int i = 1;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create? ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string svar = Console.ReadLine();
        
        Console.WriteLine("Name: ");
        string namn = Console.ReadLine();

        Console.WriteLine("Short description: ");
        string beskriving = Console.ReadLine();

        Console.WriteLine("Assign a point value: ");
        string stringPoints = Console.ReadLine();
        int poänger = int.Parse(stringPoints);

        if (svar == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(namn,beskriving,poänger);
            _goals.Add(simpleGoal);
        }
        else if (svar == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(namn,beskriving,poänger);
            _goals.Add(eternalGoal);
        }
        else if (svar == "3")
        {
            Console.WriteLine("How many times do you want to accomplish this? ");
            string stringAmounts = Console.ReadLine();
            int target = int.Parse(stringAmounts);

            Console.WriteLine("What point bonus is there for reaching a goal?");
            string stringBonus = Console.ReadLine();
            int bonus = int.Parse(stringBonus);
            
            ChecklistGoal checklistGoal = new ChecklistGoal(namn,beskriving,poänger,target,bonus);

            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        int i = 1;
        Console.WriteLine("What goal would you like to update?");
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStringRepresentation()}");
            i++;
        }
        
        string stringGoal = Console.ReadLine();
        int goalSelect = int.Parse(stringGoal);
        
        Goal selectedGoal = _goals[goalSelect - 1];

        selectedGoal.RecordEvent();
        
    }

    public void SaveGoals(string filename)
    {
        string jsonString = JsonSerializer.Serialize(_goals);
        File.WriteAllText(filename, jsonString);
    }

    public void LoadGoals(string filename)
    {

        string fileContent = File.ReadAllText(filename);

        List<Goal> goals = JsonSerializer.Deserialize<List<Goal>>(fileContent);
        _goals.AddRange(goals);

    }
}