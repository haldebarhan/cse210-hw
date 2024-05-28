public class SimpleGoal(string shortName, string description, int point, bool IsCompleted) : Goal(shortName, description, point)
{
    private bool _IsCompleted = IsCompleted;
    public override string GetStringRepresentation()
    {
        string message = $"{GetClassName()}: {GetShortName()}, {GetDescription()}, {GetPoint()}, {IsCompleted()}";
        return message;
    }

    public override bool IsCompleted()
    {
        if (_IsCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override void RecordEvent()
    {
        _IsCompleted = true;
    }

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
}