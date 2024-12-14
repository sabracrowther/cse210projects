using System;

public class Pet
{
    protected string _name;
    protected string _petType;
    protected string _color;
    protected string _description;
    protected int _numInteractions;
    protected int _score;
    protected int _currentPoints;

    //set Lists to private so they can't be changed
    private List<string> _movements;
    private List<string> _interactions;
    private List<string> _bodyFeatures;
    private List<string> _vocalizations;
    private int _frstInteractionPoints = 10;
    private Random rand = new Random();
    

    public Pet() //default constructor
    {        
        //minimum for any type of animal
        _movements = new List<string> {"eat", "sleep"};
        _interactions = new List<string> {"watch"};
        _bodyFeatures = new List<string> {"eyes", "head"};
        _vocalizations = new List<string> {""};  //none is default  
        _score = 0;
        _numInteractions = 0;
        _currentPoints = 0;      
    }

    public string Color{
        get => _color;
    }

    public string Petype
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
        _vocalizations.AddRange(strArray.ToList());
    }

    protected void ReplaceVocalizations(List<string> strList)
    {
        _vocalizations.AddRange(strList);
    }

    public int InteractForPoints()
    {
        _currentPoints = _frstInteractionPoints;
        _score += _currentPoints;
        _numInteractions++;
        return _score;
    }
   
    public virtual string GetPetInfo()
    {
        return $"Your pet's name is {_name}, it is a {_petType}, and it is {_color}.";
    }

}