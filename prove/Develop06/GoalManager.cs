using System;
using System.Collections.Generic;
using System.Linq;

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
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Goal Manager");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List All Goals");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Record Event for a Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Display Total Score");
            Console.WriteLine("8. Exit");
            Console.Write("\nChoose an option (1-8): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    RecordEvent();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    DisplayPlayerInfo();
                    break;
                case "8":
                    isRunning = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose a valid option (1-8).");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total Score: {_score}");
        Console.WriteLine("Goals List:");
        ListGoalNames();
        PauseAndReturn();
    }
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            string status = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal._shortName} - {goal._description} - {goal._points} points");
        }
        PauseAndReturn();
    }
    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        PauseAndReturn();
    }
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("Create a new goal");
        Console.WriteLine("\nGoal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        string type = Console.ReadLine();
        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Goal description: ");
        string description = Console.ReadLine();
        Console.Write("Goal points: ");
        int point = int.Parse(Console.ReadLine());
        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, description, point));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, description, point));
        }
        else if (type == "3")
        {
            Console.Write("Enter the target number of times to complete the goal: ");
            int objetive = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for completing the goal: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, point, objetive, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }
        Console.WriteLine("\nGoal Created Successfully!");
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    public void RecordEvent()
    {
        Console.Clear();
        Console.WriteLine("Register Event for a Goal");

        Console.Write("Goal Name: ");
        string goalName = Console.ReadLine();

        var goal = _goals.FirstOrDefault(g => g._shortName.Equals(goalName, StringComparison.OrdinalIgnoreCase));
        if (goal != null)
        {
            goal.RecordEvent();
            if (goal.IsComplete())
            {
                _score += goal._points;
                Console.WriteLine("Recorded event. Goal completed!");
            }
            else
            {
                Console.WriteLine("Recorded event.");
            }
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        string fileName = "goals.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
        PauseAndReturn();
    }
    public void LoadGoals()
    {
        Console.WriteLine("Goals loaded.");
        PauseAndReturn();
    }
    public void PauseAndReturn()
    {
        ShowSpinner(5); 
 
    }
    public void ShowSpinner(int seconds)
    {
        
    }
}