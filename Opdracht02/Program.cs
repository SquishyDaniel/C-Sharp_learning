namespace hoofdstuk_1;

class Program
{
    static void Main(string[] args)
    {
        /* 1. Welkom bij C# is het meest geschikt als een string, omdat het een reeks characters is. */
        String a = "Welkom bij C#!";
        Console.WriteLine(a);
        
        /* 2. 260 is het meest geschikt als een int, omdat dat het veel word gebruikt en een groot bereik heeft, maar short
         kan ook.*/
        short b = 260;
        int c = 260;
        Console.WriteLine(b);
        Console.WriteLine(c);
        
        /* 3. -56 is het meest geschikt als een int voor dezelfde reden als vraag 2 en kan ook short worden gebruikt.*/
        short d = -56;
        int e = -56;
        Console.WriteLine(d);
        Console.WriteLine(e);
        
        /* 4. 2001,99 is het meest geschikt als een double, omdat double comma getallen accepteert.*/
        double f = 2001.99;
        Console.WriteLine(f);
        
        /* 4. K1ngd0m is het meest geschikt als een string, omdat het een reeks characters is en de getallen niet uitgerekent
         of grebruikt te hoeven worden.*/
        String g = "k1ngd0m";
        Console.WriteLine(g);

    }
}