class Scripture
{
    private Reference _reference;
    private List<Word> _words;


    public Scripture(Reference reference, List<Word> text)
    {
        _reference = reference;
        _words = text;
    }

    public void HideRandomWords(int numberToHide = 3)
    {
        List<Word> test = [];
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                test.Add(word);
            }
        }
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomGenerator = new();
            int randomInt = randomGenerator.Next(0, test.Count);
            Word word = test[randomInt];
            int index = _words.IndexOf(word);
            _words[index].SetIsHidden(true);
        }
    }
    public string GetDisplayText()
    {
        string text = $"\n{_reference.GetDisplayText()} ";
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == true)
            {
                word.Hide();
                text += string.Concat(word.GetDisplayText() + ' ');
            }
            else
            {
                word.Show();
                text += string.Concat(word.GetDisplayText() + ' ');
            }
        }
        return text;
    }


    public List<Word> GetWords()
    {
        return _words;
    }

    public int GetWordsLength()
    {
        return _words.Count;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() != true)
            {
                return false;
            }
        }
        return true;
    }
}