using System;
using System.Diagnostics;

/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, int completed = 0) : base(name,points,description) 
    {
        _type = 1;
        _completed = completed;
    }

    public override string getGoal()
    {   
        if (_completed == 1)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }
    public override string getParsedGoal()
    {
        return $"{_type},{_name},{_description},{_points},{_completed}";
    }

    public override int completeGoal()
    {
        _completed = 1;
        Console.WriteLine($"Congratulations! You have now earned {_points} points!");
        Console.WriteLine($"You now have {_points} points.");
        return _points;
    }
}