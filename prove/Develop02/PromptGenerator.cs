class PromptGenerator {

public List<string> _prompts = [];

public string GetRandomPrompt(){
    string filePath = "./Prompts.txt";
    Random randomGenerator = new();
    int index = randomGenerator.Next(0, 60);
        try{
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines){
                _prompts.Add(line);
            }
        }
        catch(IOException e){
            Console.WriteLine($"File read error : {e.Message}");
        }
        catch(Exception e){
            Console.WriteLine($"An error has occurred : {e.Message}");
        }

        string prompt = _prompts[index];
        return prompt;
}
}



