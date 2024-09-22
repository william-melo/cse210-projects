using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
            
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int result = number * number;
            return result;
        }

        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"Hello, {userName}! The square of your number is {square}.");
        }

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square);
    }
}