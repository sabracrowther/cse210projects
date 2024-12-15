using System;

public class Bird : Pet
{
    private string[] strMovement = ["run", "sleep", "fly"];
    private List<string> interactions = new List<string> {"pet", "talk to them", "teach them tricks", "feed them"};
    private List<string> vocalizations = new List<string> {"tweet", "squak", "sing"};
    private List<string> bodyFeatures = new List<string> {"feet", "feathers", "tail"};

    public Bird(string name, string color) : base()
    {
        _petType = "bird";
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

    public override string Happy(){  
        return "Your bird is singing!"; 
    }

}