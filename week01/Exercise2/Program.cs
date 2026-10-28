using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        
        string letter = "";
        string sign = ""; 
        if (gradePercentage >= 90)
        {
             letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
             letter = "C";
        }
        else if (gradePercentage >= 60)
        {
             letter = "D";
        }
        else 
        {
             letter = "F";
        }

        float last_digit = gradePercentage %10;

        if (last_digit >= 7)
        {
             sign = "+";
        }
        else if (last_digit < 3)
        {
             sign = "-";
        }
        else 
        {
             sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!!");
        }
    }
}