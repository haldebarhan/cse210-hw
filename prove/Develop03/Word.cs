class Word
{

    private string _text;
    private bool _isHidden;
    private string _originalWord;

    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
        _originalWord = text;
    }


    public void Hide()
    {
        _text = new string('_', _originalWord.Length);
    }
    public void Show()
    {
        _text = _originalWord;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public string GetDisplayText() { return _text; }
}