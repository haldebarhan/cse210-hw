public abstract class Activity
{

    protected DateTime _activityDate;
    protected int _activityDuration;
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public Activity(DateTime date, int duration)
    {
        _activityDate = date;
        _activityDuration = duration;
    }
    public DateTime GetActivityDate()
    {
        return _activityDate;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityDate(DateTime dateTime)
    {
        _activityDate = dateTime;
    }

    public void SetActivityDuration(int duration)
    {
        _activityDuration = duration;
    }

    public void GetSummary()
    {
        string message = $"{GetActivityDate():dd MMM yyyy} {GetClassName()} ({GetActivityDuration()} min) - Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
        Console.WriteLine(message);
    }

    public string GetClassName()
    {
        return GetType().Name;
    }
}