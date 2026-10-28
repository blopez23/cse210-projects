using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        while(userNumber != 0)
        {
            Console.WriteLine("Enter a list of number, type 0 when you finished");
            string inputNumber = Console.ReadLine();
            userNumber = int.Parse(inputNumber);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum of all of your numbers is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int bestSoFar = -1;

        foreach (int number in numbers)
        {
            if (number > bestSoFar)
            {
                bestSoFar = number;
            }  
        }
        Console.Write($"The highest number is: {bestSoFar}");
        int smallestSoFar = 999999999;
        
        Console.WriteLine("");

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestSoFar)
            {
                smallestSoFar = number;
            }  
        }
        Console.Write($"The smallest positive number is: {smallestSoFar}");
    }
    
}