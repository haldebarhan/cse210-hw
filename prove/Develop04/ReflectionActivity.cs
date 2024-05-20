class ReflectionActivity(string name, string description, int duration = 20) : Activity(name, description, duration)
{
    private List<string> _prompts = Prompts.GetDataFromFile("Prompts.txt");
    private List<string> _questions = Prompts.GetDataFromFile("Questions.txt");

    public void Run()
    {
        Console.Clear();
        DisplayPrompt();
        Console.ReadLine();
        Description.Pause();
        ShowCountDown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime){
            DisplayQuestion();
        }
    }

    public string GetRandomPrompt()
    {
        Random randomGenerator = new();
        int randomIndex = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new();
        int randomIndex = randomGenerator.Next(0, _questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine();
        string message = @$"Considere the following prompt:

        --- {prompt} ---";
        Console.WriteLine(message);
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"\n> {question} ");
        ShowSpinner();
    }
}