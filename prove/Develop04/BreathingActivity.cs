class BreathingActivity(string name, string description, int duration = 20) : Activity(name, description, duration)
{
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> message = ["Breathe in...", "Now breathe out..."];
        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n{message[index]}");
            ShowCountDown();
            index++;
            if (index >= message.Count)
            {
                index = 0;
            }

        }
        DisplayEndingMessage();
    }
}