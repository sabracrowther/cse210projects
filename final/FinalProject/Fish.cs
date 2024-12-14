using System;

public class Fish : Pet
{
    public Fish(string name, string color) : base()
    {
        _petType = "fish";
        _name = name;
        _color = color;

        
        //add movements for this type
        string[] strMovement = ["swim", "sleep", "open and close mouth"];
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        List<string> interactions = new List<string> {"watch them", "feed them", "talk to them"};
        AddInteractions(interactions);
        //add vocalizations for this type
        List<string> vocalizations = new List<string> {"bloop"};
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        List<string> bodyFeatures = new List<string> {"fins", "scales", "tail", "lips"};
        AddBodyFeatures(bodyFeatures);
    
    }
}