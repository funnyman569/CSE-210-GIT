
class EternalGoals : Goals
{
    public EternalGoals() : base()
    {
        _goalType = "Eternal";
    }

    public override void AddGoalToList(List<string> AllGoalsList)
    {
        _AllGoalsList.Add($"Goal Name: {_goalName} \nGoal Description: {_goalDescription} \nGoal Value: {_points}");
    }

     public override void FinishGoal(bool awardPoints)
    {
        if (awardPoints)
        {
            SetTotal(GetTotal() + _points);
        }
        else
        {
            Console.WriteLine("No Points Added");
        }
        UpdateGoalStatus(); // Ensure the goal status is updated
    }
}

    