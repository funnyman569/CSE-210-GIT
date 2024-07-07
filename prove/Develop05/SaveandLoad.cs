class SaveAndLoad: Goals
{
    public SaveAndLoad() : base() {}

    public override void FinishGoal(bool awardPoints)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        System.Console.WriteLine("What would you like to name your text file? (please do not include .txt)");
        string fileName = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"Your Score: {_total}");
            outputFile.WriteLine("Your Goals");
            foreach (var goal in _AllGoalsList)
            {
                outputFile.Write(goal);
            }
            
        }
    }
}