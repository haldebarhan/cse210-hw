class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address;
    }


    public void SetTitle(string title)
    {
        _title = title;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetDate(string date)
    {
        _date = date;
    }
    public void SetTime(string time)
    {
        _time = time;
    }

    public void SetAddress(string address)
    {
        _address = address;
    }

    public void ShortDescription()
    {
        string message = $"Event Type: {GetClassName()} \nTitle: {GetTitle()} \nDate: {GetDate()}";
        Console.WriteLine(message);
    }

    public void StandardDetails()
    {
        string message = $"Title: {GetTitle()} \nDescription: {GetDescription()} \nTime: {GetTime()} \nAddress: {GetAddress()}";
        Console.WriteLine(message);
    }

    public string GetClassName()
    {
        return GetType().Name;
    }
}