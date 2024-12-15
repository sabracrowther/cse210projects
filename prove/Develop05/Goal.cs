using System;

public class Goal
{
    private int _pointsPossible; // total pts associated with a goal input by user at creation
    private string _goalName;
    private string _goalDescription;
    private string _goalType;
    private int _pointsCurrent; //accumulated points earned for the goal

    private bool complete = false;

    public Goal()
    {
        _pointsPossible = 0;
        _goalName = "";
        _goalDescription = "";
        _goalType = "";
        _pointsCurrent = 0;

    }

    public Goal(string goalType, string goalName, string goalDescription, int pointsPossible) //return bool to confirm
    {
        _pointsPossible = pointsPossible;
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalType = goalType;
        _pointsCurrent = 0; //on construction, points current is 0
        
        
        //check points possible >0
        //if all is good return true; else false
    }


    public virtual Goal CreateNew()
    {//get inputs from screen and create new obj from inputs
        Console.Write("What is the name of your goal? ");
         _goalName = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
         _goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with your goal? ");
        _pointsPossible = int.Parse(Console.ReadLine());
        // Console.WriteLine("Congratulations! New goal created!!");    
      
        return this;
    }

    public virtual int RecordEventPoints() //return earned points
    {
       _pointsCurrent =  _pointsCurrent + _pointsPossible; //add pts earned to total pts and store in _pointsCurrent
        return _pointsPossible; //return points earned
    }

    public virtual int RecordEventPoints(int addPoints) //return earned points
    {//this method allows us to add bonus points for checklist goals
       _pointsCurrent =  _pointsCurrent + addPoints;
        return addPoints; //return points earned
    }


    public int GetScore()
    {
        return _pointsCurrent;
    }

    public virtual string ListGoal()
    {
        return $"{_goalName} ({_goalDescription})";
        
    }

    public virtual string PipeDelimitedOutput()
    {
        string str = "";
        str = _goalType + ":" + _goalName + "|" + _goalDescription + "|" + _pointsPossible + "|" + _pointsCurrent;
        return str;
    }

    public virtual Goal PipeDelimitedImport(string strToParse)
    {        
        
        //parse from pipe delimited
        string[] parts = strToParse.Split("|");
        _goalName = parts[0];
        _goalDescription = parts[1];
        _pointsPossible = int.Parse(parts[2]);
        _pointsCurrent = int.Parse(parts[3]);

        return this;
    
    }



    public string GetGoalName()
    {
        return _goalName;
    }

   

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public string SetGoalType(string goalType)
    {
        _goalType = goalType;
        return _goalType;
    }

    public string GetGoalType()
    {
        return _goalType;
    }

    

    public int GetPointsCurrent()
    {
        return _pointsCurrent;
    }

    public int GetPointsPossible()
    {
        return _pointsPossible;
    }

   


    public virtual bool IsComplete()
    {
        return complete;
    }





}