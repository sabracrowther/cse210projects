using System;

public class Cat : Pet
{
    public Cat(string name, string color) : base()
    {
        _petType = "cat";
        _name = name;
        _color = color;

        
        //add movements for this type
        string[] strMovement = ["run", "sleep", "rub against you"];
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        List<string> interactions = new List<string> {"pet", "play with toys", "watch them", "play with lasers", "feed them"};
        AddInteractions(interactions);
        //add vocalizations for this type
        List<string> vocalizations = new List<string> {"meow", "purrrr", "hiss"};
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};
        AddBodyFeatures(bodyFeatures);
    
    }
}