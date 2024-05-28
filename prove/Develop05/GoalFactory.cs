public static class GoalFactory
{
    public static Goal CreateGoalFromString(string goalString)
    {
        if (string.IsNullOrWhiteSpace(goalString))
        {
            throw new ArgumentException("Invalid goal string.");
        }

        string[] items = goalString.Split(":");
        if (items.Length < 2)
        {
            throw new ArgumentException("Invalid goal string format.");
        }

        string type = items[0];
        string[] parts = items[1].Split(", ");
        switch (type)
        {
            case "SimpleGoal":
                if (parts.Length != 4) throw new ArgumentException("Invalid SimpleGoal format.");
                return CreateSimpleGoal(parts);
            case "EternalGoal":
                if (parts.Length != 3) throw new ArgumentException("Invalid EternalGoal format.");
                return CreateEternalGoal(parts);
            case "CheckListGoal":
                if (parts.Length != 6) throw new ArgumentException("Invalid CheckListGoal format.");
                return CreateCheckListGoal(parts);
            default:
                throw new ArgumentException("Unknown goal type.");
        }
    }

    private static SimpleGoal CreateSimpleGoal(string[] parts)
    {
        try
        {
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool completed = bool.Parse(parts[3]);
            return new SimpleGoal(name, description, points, completed);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error creating SimpleGoal.", ex);
        }
    }

    private static EternalGoal CreateEternalGoal(string[] parts)
    {
        try
        {
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            return new EternalGoal(name, description, points);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error creating EternalGoal.", ex);
        }
    }

    private static CheckListGoal CreateCheckListGoal(string[] parts)
    {
        try
        {
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            int bonus = int.Parse(parts[3]);
            int target = int.Parse(parts[4]);
            int accomplished = int.Parse(parts[5]);
            return new CheckListGoal(name, description, points, accomplished, target, bonus);
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Error creating CheckListGoal.", ex);
        }
    }
}
