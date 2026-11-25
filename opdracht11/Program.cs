namespace opdracht11;

class Program
{
    static void Main(string[] args)
    {
        Boolean run = true;
        Console.WriteLine("Welk menu zou jij willen?");
        Console.WriteLine("Menu 1");
        Console.WriteLine("Menu 2");
        Console.WriteLine("Geen van beide");

        while (run == true)
        {
            double input;
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            input = char.GetNumericValue(key.KeyChar);
            
            switch (input)
            {
                case 1:
                    Console.WriteLine("Menu 1 gekozen");
                    break;
                case 2:
                    Console.WriteLine("Menu 2 gekozen");
                    break;
               case 3:
                    run = false;
                    break;
               default:
                    Console.WriteLine("Ongeldige keuze voer 1,2 of 3 in alstublieft.");
                    break;
               
            }
            
        }
        
        
    }
}