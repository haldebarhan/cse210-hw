public abstract class Goal(string shortName, string description, int point)
{
    protected string _shortName = shortName;
    protected string _description = description;
    protected int _point = point;

    public abstract void RecordEvent();
    public abstract bool IsCompleted();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string detail = $"{_shortName} ({_description})";
        string message;
        if (IsCompleted())
        {
            message = string.Concat(string.Concat(string.Concat("[", "X"), "] "), detail);
        }
        else
        {
            message = string.Concat(string.Concat("[ ", "] "), detail);
        }

        return message;
    }


    public string GetClassName()
    {
        return GetType().Name;
    }

    public string GetShortName()
    {
        return _shortName;
    }


    public string GetDescription()
    {
        return _description;
    }

    public virtual int GetPoint()
    {
        return _point;
    }
}