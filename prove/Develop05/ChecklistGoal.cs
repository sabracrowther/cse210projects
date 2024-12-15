using System;

 public class ChecklistGoal : Goal
 {

    private bool _complete;
    private int _numTimesNeeded;
    private int _numTimesCompleted;
    private int _bonusAmount;


    public ChecklistGoal() : base ()
     {
        base.SetGoalType("Checklist");
        _complete = false;
        _numTimesNeeded = 0;
        _numTimesCompleted = 0;
        _bonusAmount = 0;
     }

    public ChecklistGoal( string goalName, string goalDescription, int pointsPossible, int numTimes, int bonusAmount) : base("Checklist", goalName, goalDescription, pointsPossible)
    {   
        _complete = false;
        _numTimesNeeded = numTimes;
        _numTimesCompleted = 0;
        _bonusAmount = bonusAmount;
    }

    public override ChecklistGoal CreateNew()
    {
        base.CreateNew();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _numTimesNeeded = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusAmount = int.Parse(Console.ReadLine());
        
        
        return this;
    }

    public override string ListGoal()
    {
        string str = " ";
        if (_complete == true)
        {
            str = "X";
        }
        return $"[{str}] {base.ListGoal()} -- Currently completed: {_numTimesCompleted}/{_numTimesNeeded}";
    }

    public override string PipeDelimitedOutput()
    {
        string str = "";
        str = base.PipeDelimitedOutput();
        str = str + "|" + _complete + "|" + _bonusAmount + "|" + _numTimesNeeded + "|" + _numTimesCompleted;
        return str;
    }

    public override ChecklistGoal PipeDelimitedImport(string strToParse)
    {        
        
        //parse from pipe delimited
        base.PipeDelimitedImport(strToParse);
        string[] parts = strToParse.Split("|");
        _complete = bool.Parse(parts[4]);
        _bonusAmount = int.Parse(parts[5]);
        _numTimesNeeded = int.Parse(parts[6]);
        _numTimesCompleted = int.Parse(parts[7]);


        return this;
    
    }

    public override int RecordEventPoints() //return current points
    {
        int pointsEarned = 0;
        if (_complete == false) //it is completed after the total number of times is recorded for ex. 3/3
        {   
            //first time - update current points and numTimes completed
            pointsEarned = this.GetPointsPossible();
            base.RecordEventPoints(pointsEarned);
            _numTimesCompleted++;

            //when numtimesCompleted = _numtimes you get bonus points
            if (_numTimesNeeded == _numTimesCompleted)
            {
                pointsEarned = pointsEarned + _bonusAmount;
                base.RecordEventPoints(_bonusAmount);       //add bonus points to current pts
                _complete = true;   //mark completed

            }
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            Console.WriteLine("Total points for this goal are now:" + this.GetPointsCurrent());   
            if (_complete == true)
            {
                Console.WriteLine("You completed it! You deserve a treat! ");
            }
           
        }
        else //if goal is already complete, no more points are awarded
        {
            Console.WriteLine("This goal has already been completed. Please create a new goal to earn more points.");
        }

        return pointsEarned; //return points earned
    }

    public override bool IsComplete()
    {
        return _complete;
    }
    



 }