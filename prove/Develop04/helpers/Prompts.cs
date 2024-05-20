class Prompts
{
    public static List<string> GetDataFromFile(string fileName)
    {
        List<string> prompts = [];
        string filePath = $"./helpers/{fileName}";
        try
        {
            StreamReader sr = new(filePath);
            string line = sr.ReadLine();
            while (line != null)
            {
                prompts.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            return prompts;
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return null;
        }
    }
}