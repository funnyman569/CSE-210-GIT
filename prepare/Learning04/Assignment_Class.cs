using System.Dynamic;

public class Assignment
{
    protected string _studentName;
    protected string _topic;
    
    public Assignment()
    {
        _studentName = "Yo Mama";
        _topic = "Walter White's Chemistry";
    }

    public string GetName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"{_studentName}, {_topic}";
    }
}