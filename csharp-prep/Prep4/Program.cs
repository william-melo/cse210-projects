using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);
        numbers.Add(userNumber);

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            input = Console.ReadLine();
            userNumber = int.Parse(input);
            numbers.Add(userNumber);
        }

        int sumaTotal = numbers.Sum();
        int average = sumaTotal / numbers.Count; 

        List<int> sortedNumbers = new List<int>();
        numbers.Sort();
        sortedNumbers = numbers;
        int largestNumber = sortedNumbers[^1];

        Console.WriteLine($"The sum is: {sumaTotal}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}