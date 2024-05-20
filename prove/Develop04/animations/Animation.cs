using System;
class Animation
{
    public static void LoadingText(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(text[i]);
            Thread.Sleep(50);
        }
    }

    public static void Spinner(int second = 5)
    {
        List<string> animationString = ["|", "/", "-", "\\", "|", "/", "-", "\\"];
        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);
        while (DateTime.Now < endTime)
        {
            string spin = animationString[i];
            Console.Write(spin);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

    }
}


