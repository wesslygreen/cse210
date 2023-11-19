using System;
using System.Reflection.Metadata;

/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

class ChecklistGoal : Goal
{
    private int _target;
    private int _bonusPoints;
    private int _timesCompleted =  0;

    public ChecklistGoal(string name, string description, int points, int target, int bonusPoints, int timesCompleted = 0) : base(name, points, description)
    {
        _target = target;
        _bonusPoints = bonusPoints;
        _type = 3;
        _timesCompleted = timesCompleted;
    }

    public override string getGoal()
    {   
        if (_timesCompleted == _target)
        {
            return $"[X] {_name} ({_description} -- Currently completed: {_timesCompleted}/{_target})";
        }
        else 
        {
            return $"[ ] {_name} ({_description} -- Currently completed: {_timesCompleted}/{_target})";
        }
    }

    public override string getParsedGoal()
    {
        return $"{_type},{_name},{_description},{_points},{_target},{_bonusPoints},{_timesCompleted}";
    }

    public override int completeGoal()
    {
        _timesCompleted ++;
        Console.WriteLine($"Congratulations! You have now earned {_points} points!");
        Console.WriteLine($"You now have {_points} points.");
        return _points;
    }

}