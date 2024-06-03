class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, string address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public string GetRsvp()
    {
        return _rsvp;
    }

    public void SetRsvp(string rsvp)
    {
        _rsvp = rsvp;
    }

    public void FullDetails()
    {
        string message = $"Event Type: {GetClassName()} \nTitle: {GetTitle()} \nDescription: {GetDescription()} \ndate: {GetDate()} \nTime: {GetTime()} \nAddress: {GetAddress()} \nEmail for RSVP: {GetRsvp()}\n";
        Console.WriteLine(message);
    }
}