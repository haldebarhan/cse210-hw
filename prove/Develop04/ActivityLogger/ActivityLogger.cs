class ActivityLogger
{
    private static Dictionary<string, int> _activity = [];
    private static string _baseDirectory = Directory.GetCurrentDirectory();

    public static void SaveActivity(string name, int duration)
    {
        if (_activity.ContainsKey(name))
        {
            _activity[name] += duration;
        }
        else
        {
            _activity[name] = duration;
        }
    }

    public static void SaveToFile()
    {
        string diariesDirectory = Path.Combine(_baseDirectory, "Diaries");
        if (!Directory.Exists(diariesDirectory))
        {
            Directory.CreateDirectory(diariesDirectory);
        }
        string fileName = GenerateFile();
        string filePath = Path.Combine(diariesDirectory, fileName);
        try
        {
            using StreamWriter streamWriter = new(filePath);
            string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            streamWriter.WriteLine($"Activity diary of {dateTime}");
            streamWriter.WriteLine();
            foreach (var kvp in _activity)
            {
                List<int> times = ConvertSecondToTime(kvp.Value);
                streamWriter.WriteLine($"[{kvp.Key} Activity] elapsed time for the activity {times[0]} Hours {times[1]} minutes {times[2]} seconds");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex}");
        }
    }

    private static string GenerateFile()
    {
        string dateTime = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss").Replace("-", "").Replace(" ", "");
        string filePath = $"{dateTime}.txt";
        return filePath;
    }

    private static List<int> ConvertSecondToTime(int second)
    {
        int hours = second / 3600;
        int minutes = hours / 60;
        int remaining_seconds = second % 60;

        List<int> times = [hours, minutes, remaining_seconds];
        return times;
    }
}