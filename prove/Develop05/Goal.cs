
abstract class Goals
{
    protected int _points;
    public int _total;
    protected string _goalName;
    protected string _goalDescription;
    protected string _goalType;
    public List<string> _AllGoalsList;
    protected bool _awardPoints;
    protected string _goalCheckBox;

    // Constructor
    public Goals()
    {
        _goalName = "no name";
        _goalDescription = "no description";
        _points = 0;
        _total = 0;
        _awardPoints = false;
        _goalCheckBox = "[ ]";
        _AllGoalsList = new List<string>();
    }

    public void MakeGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        SetGoalName(Console.ReadLine());

        Console.WriteLine("What is the purpose of your goal?");
        SetGoalDescription(Console.ReadLine());

        Console.WriteLine("How many points is your goal worth?");
        SetPoints(int.Parse(Console.ReadLine()));
    }

    public virtual void AddGoalToList(List<string> AllGoalsList)
    {
        _AllGoalsList.Add($"{_goalCheckBox} Goal Name: {_goalName} \nGoal Description: {_goalDescription} \nGoal Value: {_points}");
    }

    public virtual void UpdateGoalStatus()
    {
        _AllGoalsList[0] = $"{_goalCheckBox} Goal Name: {_goalName} \nGoal Description: {_goalDescription} \nGoal Value: {_points}";
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public void SetAwardPoints(bool awardPoints)
    {
        _awardPoints = awardPoints;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetTotal()
    {
        return _total;
    }

    public void SetTotal(int total)
    {
        _total = total;
    }

    public void SetGoalCheckBox(string goalCheckBox)
    {
        _goalCheckBox = goalCheckBox;
    }

    public List<string> GetAllGoalsList()
    {
        return _AllGoalsList;
    }

    public void SetAllGoalsList(List<string> AllGoalsList)
    {
        _AllGoalsList = AllGoalsList;
    }

    public abstract void FinishGoal(bool awardPoints);
}