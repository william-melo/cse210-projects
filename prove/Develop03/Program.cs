using System;

class Program
{
    static void Main(string[] args)
    {
    
    // Create a new instance of the class
    Reference referencePsalms23_1 = new Reference("Salmos", "23", 1);
    Scripture psalms23_1 = new Scripture(referencePsalms23_1, "Jehová es mi pastor; nada me faltará.");

    Reference referenceJohn14_6 = new Reference("Juan", "14", 6);
    Scripture john14_6 = new Scripture(referenceJohn14_6, "Jesús le dijo: Yo soy el camino, y la verdad, y la vida; nadie viene al Padre, sino por mí.");

    Reference referenceRomans8_28 = new Reference("Romanos", "8", 28);
    Scripture romans8_28 = new Scripture(referenceRomans8_28, "Y sabemos que a los que aman a Dios, todas las cosas les ayudan a bien.");

    Reference referencePhilippians4_13 = new Reference("Filipenses", "4", 13, 14);
    Scripture philippians4_13 = new Scripture(referencePhilippians4_13, "Todo lo puedo en Cristo que me fortalece. Sin embargo, bien hicisteis en participar conmigo en mi tribulación.");

    List<Scripture> scriptureList = new List<Scripture>();
    
    scriptureList.AddRange(new Scripture[] {psalms23_1, john14_6, romans8_28, philippians4_13});
    Random random = new Random();
    int randomIndex = random.Next(0, scriptureList.Count);
    Scripture randomScripture = scriptureList[randomIndex];
        
        while(true)
        {
            Console.WriteLine(randomScripture.GetDisplayText());
            Console.WriteLine("Press 'Enter' to continue or type 'quit' to finish...");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (randomScripture.IsCompletelyHidden() == true) {
                break;
            }
            else
            {
                randomScripture.HideRandomWords(1);
                Console.Clear();
            }
        }
    }
}