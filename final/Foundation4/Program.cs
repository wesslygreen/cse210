using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> listOfActivities = new List<Activity>();

        Running running = new Running(4.5);
        running.setDate("12/06/23");
        running.setLength(25);
        listOfActivities.Add(running);

        Cycling cycling = new Cycling(15.0);
        cycling.setDate("12/06/23");
        cycling.setLength(120);
        listOfActivities.Add(cycling);

        Swimming swimming = new Swimming(25);
        swimming.setDate("12/06/23");
        swimming.setLength(30);
        listOfActivities.Add(swimming);

        foreach (Activity a in listOfActivities){
            a.getSummary();
            Console.WriteLine();
        }
    }
}