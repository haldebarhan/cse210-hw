using System.Drawing;

class CheckListGoal(string shortName, string description, int point, int amountCompleted, int target, int bonus) : Goal(shortName, description, point)
{
    private int _amountCompleted = amountCompleted;
    private int _target = target;
    private int _bonus = bonus;

    public override string GetStringRepresentation()
    {
        string message = $"{GetClassName()}: {GetShortName()}, {GetDescription()}, {GetPoint()}, {GetBonus()}, {GetTarget()}, {GetAmountCompleted()}";
        return message;
    }

    public override bool IsCompleted()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        return false;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
        else
        {
            Console.WriteLine("This goal is Completed");
        }
    }

    public override string GetDetailsString()
    {
        string baseMessage = base.GetDetailsString();
        string info = $" --- currently completed: {GetAmountCompleted()}/{GetTarget()}";
        string message = string.Concat(baseMessage, info);
        return message;

    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public override int GetPoint()
    {
        if (IsCompleted())
        {
            return _point + _bonus;
        }
        else
        {
            return _point;
        }
    }

}