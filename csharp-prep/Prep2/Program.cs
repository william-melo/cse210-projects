using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letter;

        if (gradeNumber >= 90)
        {
            letter = "A";
        }
        else if (gradeNumber >= 80)
        {
            letter = "B";
        }
        else if (gradeNumber >= 70)
        {
            letter = "C";
        }
        else if (gradeNumber >= 60)
        {
            letter = "D";
        }
        else 
        { 
            letter = "";
        }

        Console.WriteLine($"Your letter grade is {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine($"Congratulations! You have surpassed this semester.");
        }
        else {
            Console.WriteLine("No worries, next time will be better. Trust the Lord.");
        }

    }
}