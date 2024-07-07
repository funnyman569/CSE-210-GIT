class ChecklistGoal : Goals
{
    int _progressTrackerNumerator;
    int _progressTrackerDenominator;
    int _incompletePointValue;

    public ChecklistGoal() : base()
    {
        _goalType = "Checklist";
        _progressTrackerDenominator = 0;
        _progressTrackerNumerator = 0;
        _incompletePointValue = 0;
    }

    public override void AddGoalToList(List<string> AllGoalsList)
    {
        _AllGoalsList.Add($"{_goalCheckBox} Goal Name: {_goalName} \nGoal Description: {_goalDescription} \nGoal Value: {_points}\nGoal Progress: {_progressTrackerNumerator} / {_progressTrackerDenominator}");
    }

    public override void FinishGoal(bool awardPoints)
    {
        if (awardPoints)
        {
            if (_progressTrackerNumerator < _progressTrackerDenominator)
            {
                SetNumerator(GetNumerator() + 1);
                SetTotal(GetTotal() + _incompletePointValue);
            }

            if (_progressTrackerNumerator == _progressTrackerDenominator)
            {
                SetTotal(GetTotal() + _points);
                SetGoalCheckBox("[x]");
            }

            UpdateGoalStatus();
        }
        else
        {
            Console.WriteLine("No Points Added");
        }
    }

    public int GetNumerator()
    {
        return _progressTrackerNumerator;
    }

    public void SetNumerator(int numerator)
    {
        _progressTrackerNumerator = numerator;
    }

    public int GetDenominator()
    {
        return _progressTrackerDenominator;
    }

    public void SetDenominator(int denominator)
    {
        _progressTrackerDenominator = denominator;
    }

    public int GetIncompletePointValue()
    {
        return _incompletePointValue;
    }

    public void SetIncompletePointValue(int points)
    {
        _incompletePointValue = points;
    }

    public override void UpdateGoalStatus()
    {
        _AllGoalsList[0] = $"{_goalCheckBox} Goal Name: {_goalName} \nGoal Description: {_goalDescription} \nGoal Value: {_points}\nGoal Progress: {_progressTrackerNumerator} / {_progressTrackerDenominator}";
    }
}