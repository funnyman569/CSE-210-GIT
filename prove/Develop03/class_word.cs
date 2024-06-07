class Wordz
{
    private string _individualWord;
    private bool _trueFalseShow;

    

    public Wordz()
    {
        string singleWord = _individualWord;
        bool trueOrFalsetoShow = _trueFalseShow;
    }

    public string GetWordz()
    {
        return _individualWord;
    }

    public string SetWordz(string word)
    {
       _individualWord = word;
       return word;
    }

    public bool GetTrueOrFalse()
    {
        return _trueFalseShow;
    }

    public bool SetTrueOrFalse(bool trueOrFalse)
    {
        trueOrFalse = IsWordUnder();
        _trueFalseShow = trueOrFalse;
        return _trueFalseShow;
    }

    public bool IsWordUnder()
    {
     Random random = new();
     int randomNumber = random.Next(2);
     bool trueOrFalse = (randomNumber != 0) ;
     return trueOrFalse;
    }

    public int NumberOfCharactersInWord()
    {
        string stringwordWithoutSpaces = _individualWord.Replace(" ", "");
        int wordCount = stringwordWithoutSpaces.Count();
        return wordCount;
    }

    public string ChangeWordToDashes(int wordCount)
    {
        string line = "";
        for( int i = 0; i < wordCount; i ++)
        {
            line += "_ ";
        }
        return line;
    }

    

    
}