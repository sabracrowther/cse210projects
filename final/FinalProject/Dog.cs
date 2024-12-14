using System;


public class Dog : Pet
{
    
    
    public Dog(string name, string color) : base()
    {
        _petType = "dog";
        _name = name;
        _color = color;

        
        //add movements for this type
        string[] strMovement = ["walk", "run", "sniff things"];
        AddMovements(strMovement); //can also be added through a list of strings
        //add interactions for this type
        List<string> interactions = new List<string> {"pet", "chase", "ball play", "cuddle", "play frisbee", "dog park visit"};
        AddInteractions(interactions);
        //add vocalizations for this type
        List<string> vocalizations = new List<string> {"bark", "growl", "yip", "whine", "Whoof"};
        ReplaceVocalizations(vocalizations);
        //add body features for this type
        List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};
        AddBodyFeatures(bodyFeatures);
       
    }

    public override string GetPetInfo()
    {
        return $"Your pet's name is {_name}, it is a {_petType}, and it is {_color}.";
    }
    
}