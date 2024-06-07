public class MathAssignment : Assignment
{
    public string _textbookSelection;
    public string _problems;

    public MathAssignment() : base()
    {
        _textbookSelection = "The Book of Mormon";
        _problems = "Pride Cycle";
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSelection}, {_problems}";
        
    }
}