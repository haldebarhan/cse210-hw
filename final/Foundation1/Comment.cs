class Comment
{
    public string _name;
    public string _text;


    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public void ShowComment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}