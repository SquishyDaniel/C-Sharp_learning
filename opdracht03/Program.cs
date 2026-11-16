using System.Diagnostics;

namespace opdracht03;

class Program
{
    static void Main(string[] args)
    {
        string invoer = "42";
        int getal = int.Parse(invoer);
        int resultaat = getal * 2;

        Console.WriteLine("Het dubbel is: " + resultaat);
        Console.ReadLine();

        /* De output is 84, omdat je het resultaat x2 doet. Je kan een int geen string geven dus moet je het op deze manier
         doen: int getal = int.Parse(invoer) */
    }
} 