class EternalGoal(string shortName, string description, int point) : Goal(shortName, description, point)
{
    public override string GetStringRepresentation()
    {
        string message = $"{GetClassName()}: {GetShortName()}, {GetDescription()}, {GetPoint()}";
        return message;
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override void RecordEvent() {}

    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
}