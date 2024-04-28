using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firsName = Console.ReadLine();

        Console.Write("What is your first name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"your name is {lastName}, {firsName} {lastName}");
    }
}