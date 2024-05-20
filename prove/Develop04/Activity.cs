class Activity(string name, string description, int duration)
{
    protected string _name = name;
    protected string _description = description;
    protected int _duration = duration;

    public void DisplayStartingMessage()
    {
        string message = $"Welcome to the {_name} Activity \n\n{_description} \n";
        Animation.LoadingText(message);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner();
        string message = $"\nYou have completed another {_duration} seconds of the {_name} Activity.\n";
        Animation.LoadingText(message);
        ShowSpinner();
    }
    public void ShowSpinner(int second = 5)
    {
        List<string> animationString = ["|", "/", "-", "\\", "|", "/", "-", "\\"];
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);
        while (DateTime.Now < endTime)
        {
            string spin = animationString[i];
            Console.Write(spin);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration(){
        return _duration;
    }
    public void ShowCountDown(int second = 3)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public string GetActivityName(){
        return _name;
    }

}