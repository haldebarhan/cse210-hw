class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetPace() => GetActivityDuration() / GetDistance();

    public override double GetSpeed() => (double)(_distance / GetActivityDuration()) * 60;

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
}