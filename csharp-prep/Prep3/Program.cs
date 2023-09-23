using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magic_number = int.Parse(Console.ReadLine());
        int guess = 0;
        while (guess != magic_number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            if (guess < magic_number)
            {
                Console.WriteLine("higher");
            }
            if (guess > magic_number)
            {
                Console.WriteLine("lower");
            }
            

        }
        Console.WriteLine("You guessed it!");
    }
}