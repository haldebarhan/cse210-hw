using System;

class Program
{
    /* 
        ** In the creativity demonstration section, I've created an ActivityLogger class that saves data from a user's part in a txt file.
        ** I've also created an Animation class that produces different types of animation for better interaction with the user.
    */
    static void Main(string[] args)
    {
        Menu();
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();
        int IntChoice = int.Parse(choice);
        while (IntChoice != 4)
        {

            switch (IntChoice)
            {
                case 1:
                    Console.Clear();
                    string name = "Breathing";
                    string description = Description.GetDescription(name);
                    BreathingActivity breathingActivity = new(name, description);
                    breathingActivity.DisplayStartingMessage();
                    Console.Write("How long, in second, would you like for your session? ");
                    string answer = Console.ReadLine();
                    int duration = int.Parse(answer);
                    breathingActivity.SetDuration(duration);
                    Console.Clear();
                    Description.Ready();
                    breathingActivity.ShowSpinner();
                    breathingActivity.Run();
                    ActivityLogger.SaveActivity(name, duration);
                    break;

                case 2:
                    Console.Clear();
                    name = "Reflection";
                    description = Description.GetDescription(name);
                    ReflectionActivity reflectionActivity = new(name, description);
                    reflectionActivity.DisplayStartingMessage();
                    Console.Write("How long, in second, would you like for your session? ");
                    answer = Console.ReadLine();
                    duration = int.Parse(answer);
                    reflectionActivity.SetDuration(duration);
                    Console.Clear();
                    Description.Ready();
                    reflectionActivity.ShowSpinner();
                    reflectionActivity.Run();
                    reflectionActivity.DisplayEndingMessage();
                    ActivityLogger.SaveActivity(name, duration);
                    break;

                case 3:
                    name = "Listing";
                    description = Description.GetDescription(name);
                    ListingActivity listingActivity = new(name, description);
                    Console.Clear();
                    listingActivity.DisplayStartingMessage();
                    Console.Write("How long, in second, would you like for your session? ");
                    answer = Console.ReadLine();
                    duration = int.Parse(answer);
                    listingActivity.SetDuration(duration);
                    Console.Clear();
                    Description.Ready();
                    listingActivity.ShowSpinner();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                    ActivityLogger.SaveActivity(name, duration);
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("You can choose items between 1-4");
                    break;
            }
            Menu();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            IntChoice = int.Parse(choice);
        }
        string message = "\nThank you for taking part in the game. ";
        Animation.LoadingText(message);
        Animation.Spinner();
        ActivityLogger.SaveToFile();
    }


    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
    }
}