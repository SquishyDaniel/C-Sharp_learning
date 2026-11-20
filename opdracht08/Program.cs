namespace opdracht08;

class Program
{
    static void Main(string[] args)
    {
        
    Console.WriteLine("Weet jij het geluks woord?");
    string lijn = Console.ReadLine();

    lijn = lijn.ToUpper();

    string resultaat = (lijn == "LUCKY")
        ? $"Je typte {lijn} en dat is... Correct!"
        : $"Je typte {lijn} end dat is... Fout!";
    
    Console.WriteLine(resultaat);


    }
}