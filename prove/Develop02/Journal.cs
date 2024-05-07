using System;
using System.IO;
using System.Text.RegularExpressions;

partial class Journal {
    public List<Entry> _entries = [];
    public void AddEntry(Entry newEntry){
        _entries.Add(newEntry);
    }
    public void DisplayAll(){
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file){
        string filePath = $"./journals/{file}";
        try {
            foreach(Entry entry in _entries){
                using StreamWriter writer = new(filePath, true);
                writer.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
                writer.WriteLine($"{entry._entryText}");
                writer.WriteLine();
            }
        }
        catch(Exception e){
            Console.WriteLine($"Une erreur s'est produite : {e.Message}");
        }
    }
    public void LoadFromFile(string file){
        hydrate(file);
    }

    private void hydrate(string filename){
        string filePath = $"./journals/{filename}";
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            Regex datePromptRegex = MyRegex();

            string currentDate = null;
            string currentPrompt = null;
            string currentEntryText = null;

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    // Ignore empty lines
                    continue;
                }

                if (currentDate == null)
                {
                    // Try matching the first line to the regex to extract the date and prompt
                    Match match = datePromptRegex.Match(line);
                    if (match.Success)
                    {
                        currentDate = match.Groups[1].Value; // Date
                        currentPrompt = match.Groups[2].Value; // Prompt
                    }
                }
                else
                {
                    currentEntryText = line;
                    Entry entry = new(){
                        _date = currentDate,
                        _promptText = currentPrompt,
                        _entryText = currentEntryText

                    };

                    AddEntry(entry);

                    // Reset variables for next entry
                    currentDate = null;
                    currentPrompt = null;
                    currentEntryText = null;
                }
            }
        }
        catch(FileNotFoundException e){
            Console.WriteLine($"Error:{e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error while reading the file: {e.Message}");
        }
    }

    [GeneratedRegex(@"^Date: (\d{1,2}/\d{1,2}/\d{4}) - Prompt: (.+)$")]
    private static partial Regex MyRegex();
}