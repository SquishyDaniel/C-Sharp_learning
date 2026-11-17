namespace opdracht05;

class Program
{
    static void Main(string[] args)
    {
        string hoogte;
        string breedte;
        double resultaat;
        string resultaat_decimaal;
        
        Console.WriteLine("Hallo! ik reken de oppervlakte voor jou uit!");
        
        Console.WriteLine("Wat is de breedte?");
        breedte = Console.ReadLine();
        
        Console.WriteLine("Wat is de hoogte?");
        hoogte = Console.ReadLine();

        resultaat = double.Parse(hoogte) * double.Parse(breedte);
        resultaat_decimaal = string.Format("{0:F2}", resultaat);

        Console.WriteLine($"De oppervlakte is {resultaat_decimaal}!");
        Console.ReadLine();
        /*kom hiet later nog op terug*/
    }
}