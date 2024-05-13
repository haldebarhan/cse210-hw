using System;

/*
going beyond the recommended requirements, 
I've created a program that asks the user to fill in the verses they want. 
*/

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        Console.Write("\nChoose a Book Name (e.g. Genesis): ");
        string bookName = Console.ReadLine();
        Console.Write("Enter chapter number: ");
        string chapter = Console.ReadLine();
        Console.Write("Enter verse number: ");
        string verse = Console.ReadLine();
        Console.Write("You can choose an ending verse (or type 0 if not): ");
        string endVerse = Console.ReadLine();
        int IntChapter = int.Parse(chapter);
        int IntVerse = int.Parse(verse);
        int IntEndVerse = int.Parse(endVerse);
        var factory = GetValues(bookName, IntChapter, IntVerse, IntEndVerse);
        Reference reference = factory.Item1;
        List<Word> words = factory.Item2;
        Scripture scripture = new(reference, words);
        Console.Clear();
        string text = scripture.GetDisplayText();
        Console.WriteLine(text);
        Console.WriteLine("\nPress entrer to continue or type 'quit' to finish:");
        string prompt = Console.ReadLine();
        while (UserPrompt(prompt))
        {
            if (scripture.IsCompletelyHidden())
            {
                return;
            }
            Console.Clear();
            scripture.HideRandomWords();
            text = scripture.GetDisplayText();
            Console.WriteLine(text);
            Console.WriteLine("\nPress entrer to continue or type 'quit' to finish:");
            prompt = Console.ReadLine();

        }

    }


    static (Reference, List<Word>) GetValues(string bookName, int chapter, int verse, int endVerse = 0)
    {
        Reference reference;
        List<Word> text;
        if (endVerse != 0)
        {
            reference = new(bookName, chapter, verse, endVerse);
            text = VerseFinder.FindVerseText(reference.GetBookName(), reference.GetChapter(), reference.GetVerse(), reference.GetEndVerse());
        }
        else
        {
            reference = new(bookName, chapter, verse);
            text = VerseFinder.FindVerseText(reference.GetBookName(), reference.GetChapter(), reference.GetVerse());
        }
        return (reference, text);
    }

    static void DisplayMessage()
    {
        Console.Clear();
        Console.WriteLine("This Is Scripture Memorizer Program");
        Console.WriteLine("You can choose your favorite Bible verses and the program will help you memorize them.");
    }

    static bool UserPrompt(string prompt)
    {
        if (prompt == "")
        {
            return true;
        }
        return false;
    }
}