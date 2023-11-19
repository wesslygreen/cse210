using System;

/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/


class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name,points,description)
    {
        _type = 2;
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have now earned {_points} points!");
        Console.WriteLine($"You now have {_points} points.");
        return _points;
    }
}