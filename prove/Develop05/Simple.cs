using System;


public class SimpleGoal : Goal
{

    private bool _complete;

    public SimpleGoal() : base ()
     {
        base.SetGoalType("Simple");
     }

    public SimpleGoal( string goalName, string goalDescription, int pointsPossible) : base("Simple", goalName, goalDescription, pointsPossible)
    {   
        _complete = false;
    }

    public override SimpleGoal CreateNew()
    {
        base.CreateNew();
        
        return this;
    }

     public override string ListGoal()
    {
        string str = " ";
        if (_complete == true)
        {
            str = "X";
        }
        return $"[{str}] {base.ListGoal()}";
    }

    public override string PipeDelimitedOutput()
    {
        string str = "";
        str = base.PipeDelimitedOutput();
        str = str + "|" + _complete;
        return str;
    }

     public override SimpleGoal PipeDelimitedImport(string strToParse)
    {        
        
        //parse from pipe delimited
        base.PipeDelimitedImport(strToParse);
        string[] parts = strToParse.Split("|");
        _complete = bool.Parse(parts[4]);

        return this;
    
    }

    public override int RecordEventPoints() //return current points
    {
        int pointsEarned = base.RecordEventPoints();
        if (_complete == false)
        {
            
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            Console.WriteLine($"Total points for this goal are now:" + this.GetPointsCurrent());
            _complete = true;
            
        }
        else //if goal is already complete, no more points are awarded
        {
            Console.WriteLine("This goal has already been completed. Please create a new goal to earn more points.");
            pointsEarned = 0;
        }

        return pointsEarned; //return points earned
    }

    public override bool IsComplete()
    {
        return _complete;
    }

}