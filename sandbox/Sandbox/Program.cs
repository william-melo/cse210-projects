using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}