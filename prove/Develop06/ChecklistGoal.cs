using System;
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You gained {_points} points for completing the goal '{_shortName}'.");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed the goal '{_shortName}' and earned a bonus of {_bonus} points!");
            }
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - Completed {_amountCompleted}/{_target} times (Bonus: {_bonus} points)";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName} - [{(IsComplete() ? "X" : " ")}] (Completed {_amountCompleted}/{_target} times)";
    }
}