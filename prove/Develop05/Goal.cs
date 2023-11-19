using System;

/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

class Goal
{

    protected string _name;
    protected int _points;
    protected string _description;
    protected int _type;
    protected int _completed = 0;


    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public string getGoalName()
    {
        return _name;
    }
    
    public int getPoints()
    {
        return _points;
    }

    public virtual string getGoal()
    {
        return $"[ ] {_name} ({_description})";        
    }

    public virtual string getParsedGoal() 
    {
        return $"{_type},{_name},{_description},{_points}";
    }

    public virtual int completeGoal()
    {
        return 1;
    }
}