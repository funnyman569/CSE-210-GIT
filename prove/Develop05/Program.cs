using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goals> AllGoals = new();
        int totalPoints = 0;

        Console.WriteLine("Welcome to the Goals Program! \nPlease select from the list below.");
        Console.WriteLine("1. Display Score");
        Console.WriteLine("2. Make a new Goal");
        Console.WriteLine("3. Record progress of a goal");
        Console.WriteLine("4. Display Progress");
        Console.WriteLine("5. Save Goal");
        Console.WriteLine("6. Read Goal");

        int loopIndex = 0;
        bool exitKey = true;
        while (exitKey)
        {
            if (loopIndex != 0)
            {
                Console.WriteLine("Please make another selection.");
                Console.WriteLine("1. Display Score");
                Console.WriteLine("2. Make a new Goal");
                Console.WriteLine("3. Record progress of a goal");
                Console.WriteLine("4. Display Progress");
                Console.WriteLine("5. Save Goal");
                Console.WriteLine("6. Read Goal");
            }
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine($"Your current score is {totalPoints} ");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("What type of goal would you like to make? \nSimple\nEternal\nChecklist");
                string goalType = Console.ReadLine().ToLower();

                if (goalType == "simple")
                {
                    SimpleGoals newGoal = new();
                    newGoal.MakeGoal();
                    newGoal.AddGoalToList(newGoal.GetAllGoalsList());
                    AllGoals.Add(newGoal);
                }
                else if (goalType == "eternal")
                {
                    EternalGoals newGoal = new();
                    newGoal.MakeGoal();
                    newGoal.AddGoalToList(newGoal.GetAllGoalsList());
                    AllGoals.Add(newGoal);
                }
                else if (goalType == "checklist")
                {
                    ChecklistGoal newGoal = new();
                    Console.WriteLine("How many times do you want to accomplish this goal?");
                    newGoal.SetDenominator(int.Parse(Console.ReadLine()));
                    Console.WriteLine("How much will this goal be worth every time you complete it before finishing it?");
                    newGoal.SetIncompletePointValue(int.Parse(Console.ReadLine()));
                    newGoal.MakeGoal();
                    newGoal.AddGoalToList(newGoal.GetAllGoalsList());
                    AllGoals.Add(newGoal);
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Enter the index number of the goal to mark as completed:");
                int indexNumber = int.Parse(Console.ReadLine());

                if (indexNumber >= 0 && indexNumber < AllGoals.Count)
                {
                    AllGoals[indexNumber].FinishGoal(true);
                    totalPoints += AllGoals[indexNumber].GetTotal(); 
                }
                else
                {
                    Console.WriteLine("Invalid index number.");
                }
            }
            else if (userInput == "4")
            {
                foreach (var goal in AllGoals)
                {
                    foreach (var goalDetail in goal.GetAllGoalsList())
                    {
                        Console.WriteLine(goalDetail);
                    }
                }
            }
            else if (userInput == "5")
            {
                System.Console.WriteLine("What would you like to name your text file? (please do not include .txt)");
                string fileName = Console.ReadLine() + ".txt";
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine($"Your Score: {totalPoints}");
                    outputFile.WriteLine("Your Goals");
                    foreach (var goal in AllGoals)
                    {
                        foreach (var goalDetail in goal.GetAllGoalsList())
                        {
                            outputFile.Write(goalDetail);
                        }
                    }
                }
            }
            else if (userInput == "6")
            {
                System.Console.WriteLine("What is the name of the text file?");
                string filename = Console.ReadLine();
                string[] lines = File.ReadAllLines(filename);
                Goals currentGoal = null;

                foreach (string line in lines)
                {
                    if (line.StartsWith("Your Score:"))
                    {
                        totalPoints = int.Parse(line.Split(": ")[1]);
                    }
                    else if (line.StartsWith("Goal Type:"))
                    {
                        string goalType = line.Split(": ")[1];
                        switch (goalType)
                        {
                            case "Simple":
                                currentGoal = new SimpleGoals();
                                break;
                            case "Eternal":
                                currentGoal = new EternalGoals();
                                break;
                            case "Checklist":
                                currentGoal = new ChecklistGoal();
                                break;
                        }
                    }
                    else if (line.StartsWith("Goal Name:"))
                    {
                        currentGoal.SetGoalName(line.Split(": ")[1]);
                    }
                    else if (line.StartsWith("Goal Description:"))
                    {
                        currentGoal.SetGoalDescription(line.Split(": ")[1]);
                    }
                    else if (line.StartsWith("Goal Value:"))
                    {
                        currentGoal.SetPoints(int.Parse(line.Split(": ")[1]));
                    }
                    else if (line.StartsWith("Goal Progress:") && currentGoal is ChecklistGoal)
                    {
                        var progress = line.Split(": ")[1].Split(" / ");
                        (currentGoal as ChecklistGoal).SetNumerator(int.Parse(progress[0]));
                        (currentGoal as ChecklistGoal).SetDenominator(int.Parse(progress[1]));
                    }
                    else if (line.StartsWith("Incomplete Point Value:") && currentGoal is ChecklistGoal)
                    {
                        (currentGoal as ChecklistGoal).SetIncompletePointValue(int.Parse(line.Split(": ")[1]));
                    }
                    else if (string.IsNullOrWhiteSpace(line) && currentGoal != null)
                    {
                        
                        AllGoals.Add(currentGoal);
                        currentGoal = null;
                    }
                    
             
        

                    // Add the last goal if the file does not end with an empty line
                    if (currentGoal != null)
                    {
                        AllGoals.Add(currentGoal);
                    }
                        
        
                }
            }
            loopIndex += 1;
        }
    }
}