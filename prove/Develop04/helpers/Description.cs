class Description
{
    public static string GetDescription(string activityName)
    {
        string description = "";
        switch (activityName)
        {
            case "Breathing":
                {
                    description += "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
                    break;
                }

            case "Reflection":
                {
                    description += "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    break;
                }
            case "Listing":
                {
                    description += "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                    break;
                }
        }
        return description;
    }

    public static void Ready(){
        Console.WriteLine("Get Ready...");
    }


    public static void Pause(){
        Console.Write("\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
    }
}