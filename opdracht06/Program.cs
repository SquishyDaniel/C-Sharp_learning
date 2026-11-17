using System.Runtime.InteropServices.JavaScript;

namespace opdracht06;

class Program
{
    static void Main(string[] args)
    {
        string datum;
        int jaar;
        int leeftijd;

        jaar = DateTime.Now.Year;

        Console.WriteLine("Welk jaar ben jij geboren?");
        datum = Console.ReadLine();
        
        leeftijd = jaar - int.Parse(datum);
        
        Console.WriteLine($"jij bent {leeftijd} jaar oud!");

        



    }
}