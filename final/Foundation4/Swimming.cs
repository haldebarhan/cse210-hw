class Swimming : Activity
{

    private int _numberOfLaps;
    public Swimming(DateTime date, int duration, int numberOfLaps) : base(date, duration)
    {
        _numberOfLaps = numberOfLaps;
    }

    public int GetNumberOfLaps() => _numberOfLaps;

    public void SetNumerOfLaps(int numberOfLaps)
    {
        _numberOfLaps = numberOfLaps;
    }
    public override double GetDistance() => (double)(_numberOfLaps * 50) / 1000;

    public override double GetPace() => (double)(_activityDuration / GetDistance());

    public override double GetSpeed() => 60 / GetPace();
}