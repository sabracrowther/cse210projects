using System;

public class Cat : Pet
{
    private string[] strMovement = ["run", "sleep", "rub against you"];
    private List<string> interactions = new List<string> {"pet", "play with toys", "play with lasers", "feed them"};
    private List<string> vocalizations = new List<string> {"meow", "purrrr", "hiss"};
    private List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};

    public Cat(string name, string color) : base()
    {
        _petType = "cat";
        _name = name;
        _color = color;
        
        //add movements for this type
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        AddInteractions(interactions);
        //add vocalizations for this type
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        AddBodyFeatures(bodyFeatures);
    
    }

    public override string Happy(){  //can override for each pet type depending on it's abilities
        return "Your cat wants to cuddle."; 
    }
}