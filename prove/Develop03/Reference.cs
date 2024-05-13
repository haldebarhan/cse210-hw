class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public Reference(string bookName, int chapter, int verse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string bookName, int chapter, int verse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string text = $"{_bookName} {_chapter}:{_verse}";
        if (_endVerse != 0 && _endVerse > _verse)
        {
            text += string.Concat("-", _endVerse);
        }
        return text;
    }

    public string GetBookName()
    {
        return _bookName;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }
}