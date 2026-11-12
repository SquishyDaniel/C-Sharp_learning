namespace c_sharp_project;

class Program
{
    static void Main(string[] args)
    {
        string name = "Daniël";
        int age = 10;
        int how_old;

        how_old = 8;

        age = age + 10;
        age += 1;
        age += how_old;
        
        Console.WriteLine($"Hello {name} is {age} years old.");
        Console.WriteLine(age);
    }
}
