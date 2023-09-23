using System;
using System.Globalization;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = -1;
        List<int> list = new List<int>();

         while (number != 0)
         {
            Console.Write("Enter number:");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                list.Add(number);
            }

         }

        double sum = 0;
        int largest = 0;
        foreach (int num in list)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        double avg = sum / list.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");




    }
}