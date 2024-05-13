using System;
using System.Text.Json;
class VerseFinder
{
    public static List<Word> FindVerseText(string bookName, int chapter, int verse, int endVerse = 0)
    {
        try
        {
            string jsonFilePath = "./bible/bible.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            string verses = "";
            List<Word> words = [];
            string[] subs = [];

            VerseData data = JsonSerializer.Deserialize<VerseData>(jsonData);

            if (data != null && data._verses != null)
            {
                if (endVerse != 0 && endVerse > verse)
                {
                    for (int i = verse; i < endVerse + 1; i++)
                    {
                        Verse found = data._verses.Find(v =>
                        v._book_name == bookName &&
                        v._chapter == chapter &&
                        v._verse == i);

                        if (found != null)
                        {
                            verses += string.Concat(found._text + " ");
                        }
                    }
                    subs = verses.Split(" ");
                    foreach (string sub in subs)
                    {
                        Word word = new(sub, false);
                        words.Add(word);
                    }
                    return words;

                }
                else
                {
                    Verse foundVerse = data._verses.Find(v =>
                    v._book_name == bookName &&
                    v._chapter == chapter &&
                    v._verse == verse);

                    if (foundVerse != null)
                    {
                        verses = foundVerse._text;
                        subs = verses.Split(" ");
                        foreach (string sub in subs)
                        {
                            Word word = new(sub, false);
                            words.Add(word);
                        }
                        return words;
                    }
                }

            }

            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading or deserializing JSON file : {ex.Message}");
            return null;
        }
    }

}