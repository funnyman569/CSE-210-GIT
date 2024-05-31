using System.Dynamic;
using Microsoft.VisualBasic;

class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;

    public Reference()
    {
        int chapter = _chapter;
        int verse = _verse;
        string bookName = _bookName;
    }

    public string GetBookName() {return _bookName;}
    public void SetBookName(string bookName) 
    {
        _bookName = bookName;
    }
    
    public int GetChapter() {return _chapter;}
    public void SetChapter(int chapter) {_chapter = chapter;}

    public int GetVerse() {return _verse;}
    public void SetVerse(int verse) {_verse = verse;}

    public string CompileReference()
    {
        return $"{_bookName} {_chapter}:{_verse}";
    }
}