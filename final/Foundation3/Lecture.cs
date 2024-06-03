class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public void FullDetails()
    {
        string message = $"Event Type: {GetClassName()} \nTitle: {GetTitle()} \nDescription: {GetDescription()} \ndate: {GetDate()} \nTime: {GetTime()} \nAddress: {GetAddress()} \nSpeaker: {GetSpeaker()} \nCapacity: {GetCapacity()}\n";
        Console.WriteLine(message);
    }
}