using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new instance of the class
        Journal journal = new Journal();
        
        PromptGenerator promptGenerator = new PromptGenerator();

        Console.WriteLine("Welcome to the Journal Program!");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            int numChoice = int.Parse(choice);

            if (numChoice == 1)
            {   
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string text = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                Entry entry = new Entry();

                entry._date = dateText;
                entry._entryText = text;
                entry._promptText = prompt;

                journal.AddEntry(entry);
            }
            else if (numChoice == 2)
            {
                journal.DisplayAll();
            }
            else if (numChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File not found.");
                    continue;
                }

                journal.LoadFromFile(filename);
                Console.WriteLine("File loaded succesfully!");
            }
            else if (numChoice == 4)
            {
                // Save the journal to a file
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
            }
            else if (numChoice == 5)
            {
                break;
            }
            else {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
            }

        }

    }
}