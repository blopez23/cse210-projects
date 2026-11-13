//I'm Benjamin Lopez Gonzalez and my feature for the program was to add a Library of scriptures rather than using a single one
//and that the scriptures would be chose randomly

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"),

            new Scripture(new Reference("John", 14, 6), "Jesus saith unto him I am the way the truth and the life no man cometh unto the Father but by me"),

            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me"),
        };

        Random random = new Random();
        int randomIndex = random.Next(scriptures.Count);

        Scripture scripture = scriptures[randomIndex];
        

        string userInput = "";

        while(userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if(userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Program ended. Good job!!");
    }
}

