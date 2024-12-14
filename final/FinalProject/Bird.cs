using System;

public class Bird : Pet
{
    public Bird(string name, string color) : base()
    {
        _petType = "bird";
        _name = name;
        _color = color;

        
        //add movements for this type
        string[] strMovement = ["run", "sleep", "fly"];
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        List<string> interactions = new List<string> {"pet", "talk to them", "watch them", "teach them tricks", "feed them"};
        AddInteractions(interactions);
        //add vocalizations for this type
        List<string> vocalizations = new List<string> {"tweet"};
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        List<string> bodyFeatures = new List<string> {"feet", "feathers", "tail"};
        AddBodyFeatures(bodyFeatures);
    
    }
}