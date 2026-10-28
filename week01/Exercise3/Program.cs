using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = 0;
        
        while (guess != magicNumber)
        {
            Console.WriteLine("Guess a number between 1 and 100: ");
            string numberGuessed = Console.ReadLine();
            guess = int.Parse(numberGuessed);

            if (guess < magicNumber)
            {
                Console.WriteLine("Guess Higher!!");
            }
            if (guess > magicNumber)
            {
                Console.WriteLine("Guess Lower!!");
            }
            else
            {
                Console.WriteLine("You Guessed it!! Great Job");
            }
        }

    }
}