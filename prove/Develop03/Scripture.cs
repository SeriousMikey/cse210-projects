using System.Transactions;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        String[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word convertedWord = new Word(word);

            _words.Add(convertedWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int listLength = _words.Count;
        if (_words[numberToHide].IsHidden() == true)
            {
                numberToHide = 1;
                while (_words[numberToHide - 1].IsHidden() == true && numberToHide < listLength)
                {
                    numberToHide += 1;
                }
                _words[numberToHide - 1].Hide();
            }
        else
        {
            _words[numberToHide].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompletelyHidden()
    {
        bool allWordsHidden = true;
        foreach (Word word in _words)
        {
            bool check = word.IsHidden();
            if (check == false)
            {
                allWordsHidden = false;
            }
        }
        return allWordsHidden;
    }

    public List<Word> GetWordsList()
    {
        return _words;
    }
}

