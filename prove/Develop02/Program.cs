/**
    Group: Alt-Z
    Authors:
    - Stephen Beckstead
    - Truman Benjamin
    - Ethan Glenn
    - Wessly Green
    - Nii Gogoe
*/

using System;
using project1;
class Program
{
    static void Main(string[] args)
    {
        List<string> _prompts = new List<string>
        {
            "Write about a small act of kindness you witnessed or experienced today.",
            "Describe one thing you're grateful for right now.",
            "Reflect on a recent challenge you faced and how you overcame it.",
            "Write a brief note about a place you'd like to visit and why it intrigues you.",
            "What is a skill or hobby you'd like to learn more about, and what's your first step towards it?"
        };

        // Display menu function
        int menu()
        {
            // Display options
            Console.WriteLine();
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("If you want to quit, enter 0.");
            Console.Write("Please choose a number: ");
            int choice = int.Parse(Console.ReadLine());

            // Validate user input (has to be between 0 and 4)
            while (choice < 0 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                Console.Write("Please choose a number: ");
                choice = int.Parse(Console.ReadLine());
            }

            // Return user input
            return choice;
        }


        // Start of the program
        Console.WriteLine("Welcome to the Journal app!");

        // Initialize a journal object
        Journal journal = new Journal();

        // Display menu
        int choice = menu();

        // As long as user doesn't enter a 0, keep the program running
        while(choice != 0)
        {   

            // Write entry
            if (choice == 1)
            {
                Console.WriteLine();

                // Generate random number between 0-4 to get a random prompt
                Random rand = new Random();
                int randInt = rand.Next(0, _prompts.Count); 
                string randomPrompt = _prompts[randInt]; 

                // Display prompt and record user's entry
                Console.WriteLine(randomPrompt); 
                string response = Console.ReadLine();

                // Initialize an entry object and add it to the journal
                Entry entry = new Entry(response);
                entry.setPrompt(randomPrompt);
                journal.addEntry(entry);
            }

            // Display journal 
            else if (choice == 2)
            {   
                journal.Display();
            }

            // Save journal to file
            else if(choice == 3)
            {   
                // Get the filename from the user and save the file
                Console.Write("Please enter a filename (that ends with .txt): ");
                string filename = Console.ReadLine();
                journal.saveFile(filename);
            }

            // Read journal from file
            else if(choice == 4)
            {
                // Get the filename from the user and read from that file
                Console.Write("Provide the name of the file that contains the journal: ");
                string filename = Console.ReadLine();
                journal.readFile(filename);
            }

            // Display menu again
            choice = menu();
        }
    }
}