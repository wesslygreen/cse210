using System;
using System.Dynamic;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        int totalPoints = 0;

        Console.Clear();
        int choice = 0;
        // insert Load Function Here

        while (choice != 7)
        {
            displayWelcomeMessage(totalPoints);
            try
            {
                choice = int.Parse(getUserInput("Select a choice from the menu: "));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            if (choice == 1)
            {
                displayGoalOptions();
                int goal = int.Parse(getUserInput("Which type of goal would you like to create? "));
                string goalName = getUserInput("What is the name of your goal? ");
                string goalDescription = getUserInput("What is a short description of it? ");
                int points = int.Parse(getUserInput("What is the amount of points associated with this goal? "));

                if (goal == 1)
                {
                    SimpleGoal simple = new SimpleGoal(goalName, goalDescription, points);
                    _goals.Add(simple);
                }
                else if (goal == 2)
                {
                    EternalGoal eternal = new EternalGoal(goalName, goalDescription, points);
                    _goals.Add(eternal);
                }
                else
                {
                    int target = int.Parse(getUserInput("How many times does this goal need to be accomplished for a bonus? "));
                    int bonusPoints = int.Parse(getUserInput("What is the bonus for accomplishing it that many times? "));
                    ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, points, target, bonusPoints);
                    _goals.Add(checklist);
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are:");
                int index = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{index}. {goal.getGoal()}");
                    index++;
                }
            }
            else if (choice == 3)
            {

                if (_goals.Count <= 0)
                {
                    Console.WriteLine("You do not have any goals to save.");
                }
                else
                {
                    string filename = getUserInput("What is the filename for the goal file? ");

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(totalPoints);
                        foreach (Goal goal in _goals)
                        {
                            outputFile.WriteLine(goal.getParsedGoal());
                        }
                    }
                }
            }
            else if (choice == 4)
            {
                string filename = getUserInput("What is the filename for the goals file? ");
                string[] oldLines = System.IO.File.ReadAllLines(filename);

                totalPoints = int.Parse(oldLines[0]);

                string[] lines = new string[oldLines.Length - 1];

                Array.Copy(oldLines, 1, lines, 0, lines.Length);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                    if (int.Parse(parts[0]) == 1)
                    {
                        SimpleGoal simple = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]));
                        _goals.Add(simple);
                    }
                    else if (int.Parse(parts[0]) == 2)
                    {
                        EternalGoal eternal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                        _goals.Add(eternal);
                    }
                    else
                    {
                        ChecklistGoal checklist = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                        _goals.Add(checklist);
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are:");
                int index = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"\t{index}. {goal.getGoalName()}");
                    index++;
                }

                int goalCompleted = int.Parse(getUserInput("Which goal did you accomplish? "));

                int pointsToAdd = _goals[goalCompleted - 1].completeGoal();
                totalPoints += pointsToAdd;
            }
            else if (choice == 6)
            {
                Console.WriteLine("The goals are:");
                int index = 1;
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"{index}. {goal.getGoalName()}");
                    index++;
                }

                int badGoal = int.Parse(getUserInput("Which goal did you fail at? "));

                totalPoints -= _goals[badGoal - 1].getPoints() / 2;
            }
            else if (choice == 7)
            {
                string input = getUserInput("Would you like to save you stats before quitting (Y/n)? ");

                if (input.ToLower() == "y")
                {
                    string filename = getUserInput("What is the filename for the goal file? ");
                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(totalPoints);
                        foreach (Goal goal in _goals)
                        {
                            outputFile.WriteLine(goal.getParsedGoal());
                        }
                    }
                }
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid menu choice.");
            }
        }
        Console.Clear();
        Console.WriteLine("Thanks for using the Goal tracker!");
    }


    static void displayWelcomeMessage(int totalPoints)
    {
        Console.WriteLine();
        Console.WriteLine($"You have {totalPoints} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Good Event");
        Console.WriteLine("\t6. Record Bad Event");
        Console.WriteLine("\t7. Quit");
    }

    static void displayGoalOptions()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
    }

    static string getUserInput(string text)
    {
        Console.Write(text);
        string input = Console.ReadLine();
        return input;
    }

}