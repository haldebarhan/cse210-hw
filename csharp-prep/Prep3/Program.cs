using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new();

        int magicNumber = randomGenerator.Next(1, 11);
        Console.Write("What is the magic number? ");
        string answer = Console.ReadLine();

        int number = int.Parse(answer);
        while(magicNumber != number){
            if(number < magicNumber){
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Lower");
            }
            Console.Write("What is the magic number? ");
            answer = Console.ReadLine();
            number = int.Parse(answer);
        }
            Console.Write("You guessed it");
    }
}