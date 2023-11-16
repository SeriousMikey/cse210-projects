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
        if (_isHidden == true)
        {
            return _isHidden;
        }
        else
        {
            return _isHidden;
        }
    }

    public string GetDisplayText()
    {
        return _text;
    }
}