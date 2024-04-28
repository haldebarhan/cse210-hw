using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];
        int userNumber = -1;
        while(userNumber != 0){
            Console.Write("Entrer a number or 0 to quit" );
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if(userNumber != 0){
                numbers.Add(userNumber);
            }
        }
        int sum = 0;
        int largestNumber = 0;
        foreach (int number in numbers) {
            sum += number;
            if(number > largestNumber){
                largestNumber = number;
            }
        }
        float floatedSum = sum;
        float average = floatedSum/ numbers.Count();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}