public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        int textLength = _text.Length;
        _text = "";

        for (int i = 0; i < textLength; i++)
            {
                _text += "_";
            }
        _isHidden = true;
    }

    public bool IsHidden()
    {
        int textLength = _text.Length;
        string underscoredWord = "";

        for (int i = 0; i < textLength; i++)
            {
                underscoredWord += "_";
            }

        if (underscoredWord == _text)
        {
            _isHidden = true;
            return _isHidden;
        }
        else{
            _isHidden = false;
            return _isHidden;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}