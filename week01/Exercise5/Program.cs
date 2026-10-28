using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string favoriteNumber = Console.ReadLine();
        int number = int.Parse(favoriteNumber);
        return number;
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }
    static void DisplayResult(string name, int number)
    {
        Console.Write($"{name}, the square of your number is {number}");
    }
}