class SimpleGoals : Goals
{
    public SimpleGoals() : base()
    {
        _goalType = "Simple";
    }

    public override void FinishGoal(bool awardPoints)
    {
        if (awardPoints)
        {
            SetTotal(GetTotal() + _points);
            SetGoalCheckBox("[x]");
        }
        else
        {
            Console.WriteLine("No Points Added");
        }
        UpdateGoalStatus(); 
    }
}
