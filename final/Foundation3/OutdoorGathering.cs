class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, string address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetWeatherForecast()
    {
        return _weatherForecast;
    }

    public void SetWeatherForecast(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }

    public void FullDetails()
    {
        string message = $"Event Type: {GetClassName()} \nTitle: {GetTitle()} \nDescription: {GetDescription()} \ndate: {GetDate()} \nTime: {GetTime()} \nAddress: {GetAddress()} \nWeather: {GetWeatherForecast()}\n";
        Console.WriteLine(message);
    }
}