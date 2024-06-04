class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance() => (double)(GetSpeed() / 60) * GetActivityDuration();

    public override double GetPace() => 60 / GetSpeed();

    public override double GetSpeed() => _speed;

    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
}