using System;

class Program
{
    static void DisplayMenu(){
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

    }
    static void Main(string[] args)
    {
        Journal journal = new();
        DisplayMenu();
        string userPrompt = Console.ReadLine();
        int choice = int.Parse(userPrompt);
        while(choice != 5){
            switch(choice){
                case 1:
                    PromptGenerator promptGenerator = new();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    string userEntry = Console.ReadLine();
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    Entry newEntry = new(){
                        _date = dateText,
                        _promptText = prompt,
                        _entryText = userEntry
                    };
                    journal.AddEntry(newEntry);
                    break;
                
                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("What is the filename");
                    string filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;

                case 4:
                    Console.WriteLine("What is the filename");
                    string file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;

                default:
                    continue;
                
            }
            DisplayMenu();
            userPrompt = Console.ReadLine();
            choice = int.Parse(userPrompt);
        }
    }
}