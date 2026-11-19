namespace opdracht07;

class Program
{
    static void Main(string[] args)
    {
        
        int geluksgetal = 9;
        double input;

        Console.WriteLine("Hey! Kan jij mijn geluksgetal raden?");

        Console.WriteLine("Wat is mijn geluksgetal?");
        ConsoleKeyInfo toets = Console.ReadKey();
        Console.WriteLine();
        
        input = char.GetNumericValue(toets.KeyChar);
        
        if (input == geluksgetal)
        {
            Console.WriteLine($"{geluksgetal} is inderdaad mijn geluks getal!");
        }
        else
        {
            Console.WriteLine("Sorry dat is niet mijn geluksgetal.");

        }
        
        /*Kom hier later nog op terug om te verbeteren*/

    }


}