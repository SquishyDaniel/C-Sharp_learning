namespace opdracht09;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welke maat drank zou jij willen?  1. Small = €2,00.   2.  Medium = €2,50.   3.  Large = €3,00");
        int keuze = int.Parse(Console.ReadLine());

        switch (keuze)
        {
            case 1:
                Console.WriteLine("Small gekozen");
                break;
            case 2:
                Console.WriteLine("Medium gekozen");
                break;
            case 3:
                Console.WriteLine("Large gekozen");
                break;
            default:
                Console.WriteLine("Ongeldige keuze");
                break;
        }

        Console.ReadLine();
    }
}