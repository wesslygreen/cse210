using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        int userGrade = int.Parse(Console.ReadLine());
        string letterGrade;

        if (userGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (userGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (userGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (userGrade >= 60)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
        Console.WriteLine($"You got a {letterGrade}.");


        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else 
        {
            Console.WriteLine("Try harder next time.");
        }



    }
    
}