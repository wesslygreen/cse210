/**
Authors:
- Wessly Green
- Ethan Glenn
- Truman Benjamin
- Stephen Beckstead
- Nii Gogoe
*/

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture memorizer = loadScripture();
        memorizer.displayScripture();
        Console.WriteLine();
        Console.WriteLine("Press enter to continue or type 'quit' to stop the program.");
        string input = Console.ReadLine();

        while (input == "" && memorizer.allHidden() == false)
        {
            Console.Clear();
            memorizer.hideWords();
            memorizer.displayScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to stop the program.");
            input = Console.ReadLine();
        }
    }

    static Scripture loadScripture()
    {   
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");

        Random random = new Random();
        int randomIndex = random.Next(0, lines.Length);

        string[] randomValue = lines[randomIndex].Split(";");

        string[] scriptureRef = randomValue[0].Split(' ');
        string scriptureText = randomValue[1];

        Scripture memorizer = new Scripture(scriptureText);
        
        string book = scriptureRef[0] + " " + scriptureRef[1];
        string[] combined;
        try {
            combined = scriptureRef[2].Split(':');
        } catch {
            combined = scriptureRef[1].Split(':');
        }

        int chapter = int.Parse(combined[0]);    
        bool textContains = combined[1].Contains("-");
        int verse = 0;
        string verses = ""; 
        if (textContains) 
        {
            verses = combined[1];
        } else {
            verse = int.Parse(combined[1]);
        }

        memorizer.setReference(book, chapter, verse, verses);

        return memorizer;
    }
}