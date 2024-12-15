using System;

public class Pet
{
    //set Lists to private so they can't be changed badly by accident in derived classes
    private List<string> _movements;
    private List<string> _interactions;
    private List<string> _bodyFeatures;
    private List<string> _vocalizations;
    

    //can override in derived classes
    protected string _name;
    protected string _petType;
    protected string _color;
    protected int _score;   
    protected int _currentPoints;
    protected int _numInteractions; 
    protected int _minInteractionPoints = 10;


    //internal private variables
    private Random rand = new Random();
    

    public Pet() //default constructor
    {        
        //minimum for any type of animal
        _movements = new List<string> {"eat", "sleep"};
        _interactions = new List<string> {"watch"};
        _bodyFeatures = new List<string> {"eyes", "head"};
        _vocalizations = new List<string> {""};  //none is default  
        _score = 0; //cumulative score for pet
        _numInteractions = 0;
        _currentPoints = 0;      
    }

    public string Color{
        get => _color;
    }

    public string Type
    {
        get => _petType;
    }

    public string Name
    {
        get => _name;
    } 

    public int Score
    {
        get=> _score;
    }

    public int CurrentPoints
    {
        get => _currentPoints;
    }
    public int NumInteractions
    {
        get => _numInteractions;
    }

    public List<string> Movements
    {
        get => _movements;
    }

    public List<string> Interactions
    {
        get => _interactions;
    }

    public List<string> BodyFeatures
    {
        get => _bodyFeatures;
    }

    public List<string> Vocalizations
    {
        get => _vocalizations;
    }

    protected void AddMovements(string[] movementStrArray)
    {
        _movements.AddRange(movementStrArray.ToList());
    }

    protected void AddMovements(List<string> movementList)
    {
        _movements.AddRange(movementList);
    }

    protected void AddInteractions(string[] strArray)
    {
        _interactions.AddRange(strArray.ToList());
    }

    protected void AddInteractions(List<string> strList)
    {
        _interactions.AddRange(strList);
    }

     protected void AddBodyFeatures(string[] strArray)
    {
        _bodyFeatures.AddRange(strArray.ToList());
    }

    protected void AddBodyFeatures(List<string> strList)
    {
        _bodyFeatures.AddRange(strList);
    }

    protected void ReplaceVocalizations(string[] strArray)
    {
        _vocalizations = strArray.ToList();
    }

    protected void ReplaceVocalizations(List<string> strList)
    {
        _vocalizations = strList;
    }

    public int InteractForPoints()  {   //Computes current points, total score, and num interactions
        _currentPoints = _minInteractionPoints; 
        _score += _currentPoints;
        _numInteractions++;
        return _score;
    }

    public string GetPetInfo()
    {
        return $"{_name} is a {_petType}, and is {_color}.";
    }



    //can override in derived classes
    public virtual string Speak(){  //randomly pet speaks; can override in derived classes
        int randomNum = rand.Next(_vocalizations.Count);
        return _vocalizations[randomNum];
    }

    public virtual string Happy(){  //can override for each pet type depending on it's abilities
        return "Your " + _petType + " is smiling";  ////e.g. "Your dog is " + Happy() = Your dog is smiling
    }

}