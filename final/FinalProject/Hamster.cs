using System;

public class Hamster : Pet
{
    private string[] strMovement = ["run", "sleep"];
    private List<string> interactions = new List<string> {"pet", "play with them", "feed them"};
    private List<string> vocalizations = new List<string> {"squeak"};
    private List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};

    //constructor
    public Hamster(string name, string color) : base()
    {
        _petType = "hamster";
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
        return "Your hamster just let out a Whoop!"; 
    }

    public override string Speak(){  
        return vocalizations[0];    //there is only one vocalization so don't use base class using random
    }
}