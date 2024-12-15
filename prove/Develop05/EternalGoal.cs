using System;

public class EternalGoal : Goal
{
     public EternalGoal() : base ()
     {
        base.SetGoalType("Eternal");
     }
    public EternalGoal(string goalName, string goalDescription, int pointsPossible) : base ("Eternal", goalName, goalDescription, pointsPossible)
    {
        

    }

    public override string ListGoal()
    {
        return $"[ ] {base.ListGoal()}";
    }

    public override EternalGoal CreateNew()
    {
        base.CreateNew();
       
        return this;
    }

    public override EternalGoal PipeDelimitedImport(string strToParse)
    {        
        
        //parse from pipe delimited
        base.PipeDelimitedImport(strToParse);

        return this;
    
    }

}