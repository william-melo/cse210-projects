using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Provide 2 numbers to guess between them.");
        
        Console.Write("First Number: ");
        string firstNumber = Console.ReadLine(); 
        
        Console.Write("Last Number: ");
        string lastNumber = Console.ReadLine();
        
        int firstIntNumber = int.Parse(firstNumber);
        int lastIntNumber = int.Parse(lastNumber);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(firstIntNumber, lastIntNumber);

        Console.WriteLine($"Guess a number between {firstIntNumber} and {lastIntNumber}");

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        int guessCounter = 1;

        while (guessNumber != number)
        {
            if (guessNumber > number)
            {
                Console.WriteLine("Lower!");
            }
            else if (guessNumber < number)
            {
                Console.WriteLine("Higher!");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            guessCounter++;
        }

        Console.WriteLine($"You guessed it in {guessCounter} attempts.");
    }
}