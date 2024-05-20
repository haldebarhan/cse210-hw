class ListingActivity(string name, string description, int duration = 20) : Activity(name, description, duration)
{
    private int _count = 0;
    private List<string> _prompts = [];

    public void Run()
    {
        Console.Clear();
        GetRandomPrompt();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _prompts.Add(answer);

        }
        _count = _prompts.Count;
        string message = $"\nYou have listed {_count} items";
        Console.WriteLine(message);
    }

    public void GetRandomPrompt()
    {
        List<string> question = Prompts.GetDataFromFile("ReflexionPrompt.txt");
        Random randomGenerator = new();
        int randomIndex = randomGenerator.Next(0, question.Count);
        string prompt = question[randomIndex];
        string message = $"\nList as many responses you can to the following prompt:\n\b --- {prompt} ---";
        Console.WriteLine(message);
        Console.Write("\nYou may begin in: ");
        ShowCountDown();
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}