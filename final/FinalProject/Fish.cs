using System;

public class Fish : Pet
{
    private string[] strMovement = ["swim", "sleep", "open and close mouth"];
    private List<string> interactions = new List<string> {"feed them", "talk to them"};
    private List<string> vocalizations = new List<string> {"bloop"};
    private List<string> bodyFeatures = new List<string> {"fins", "scales", "tail", "lips"};


    public Fish(string name, string color) : base()
    {
        _petType = "fish";
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
        return "Your fish just did a flip!"; 
    }

    public override string Speak(){  
        return vocalizations[0];    //there is only one vocalization so don't use base class using random
    }
}