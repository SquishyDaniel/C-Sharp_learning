namespace c_sharp_project;

class Program
{
    static void Main(string[] args)
    {
        string name = "Daniël";
        int age = 11;

        age = age + 10;
        
        Console.WriteLine($"Hello {name} is {age} years old.");
        Console.WriteLine(age);
    }
}
