namespace opdracht10;

class Program
{
    static void Main(string[] args)
    {
        
        int teller = 0;

        while (teller < 10)
        {
            teller++;
            if (teller == 4)
            {
                continue;
            }
            Console.WriteLine(teller);
        }
        
        
    }
}