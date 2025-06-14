using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": DisplayPlayerInfo(); break;
                case "7": return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, desc, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, desc, points);
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, desc, points, target, bonus);
                break;
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created!");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal you accomplished:");
        ListGoalNames();

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();

            int earned = goal.GetPoints();

            if (goal is ChecklistGoal checklist)
            {
                earned += checklist.IsComplete() && checklist.GetAmountCompleted() == checklist.GetTarget() ? checklist.GetBonus() : 0;
            }

            _score += earned;

            Console.WriteLine($"Event recorded! You earned {earned} points.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(",");

                if (type == "SimpleGoal")
                {
                    var g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                    if (bool.Parse(data[3])) g.RecordEvent();
                    _goals.Add(g);
                }
                else if (type == "EternalGoal")
                {
                    _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                }
                else if (type == "ChecklistGoal")
                {
                    var g = new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]));
                    for (int j = 0; j < int.Parse(data[5]); j++) g.RecordEvent();
                    _goals.Add(g);
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
