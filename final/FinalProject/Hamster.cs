using System;

public class Hamster : Pet
{
    public Hamster(string name, string color) : base()
    {
        _petType = "hamster";
        _name = name;
        _color = color;

        
        //add movements for this type
        string[] strMovement = ["run", "sleep"];
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        List<string> interactions = new List<string> {"pet", "play with them", "watch them", "feed them"};
        AddInteractions(interactions);
        //add vocalizations for this type
        List<string> vocalizations = new List<string> {"squeak"};
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};
        AddBodyFeatures(bodyFeatures);
    
    }
}