using System;
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"You gained {_points} points for completing your eternal goal '{_shortName}'.");
    }
    public override bool IsComplete()
    {
        return false; 
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} - [ ] (Eternal)";
    }
}