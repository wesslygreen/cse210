using System;
using System.ComponentModel;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static int SquareNumber(int number)
        {
            int sqr = number * number;
            return sqr;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int favnum = PromptUserNumber();
        int sqr = SquareNumber(favnum);
        DisplayResult(name, sqr);
    }
}