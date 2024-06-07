class WritingAssignment : Assignment
{
    public string _title;

    public WritingAssignment() : base()
    {
        _title = "The time I met Spiderman";
    }

    public string GetWritingInformation()
    {
        return $"{_studentName} -- {_topic} \n{_title}";
    }
}