using System;


public class Dog : Pet
{
    string[] strMovement = ["walk", "run", "sniff things"];
    List<string> interactions = new List<string> {"pet", "chase", "ball play", "cuddle", "play frisbee", "dog park visit"};
    List<string> vocalizations = new List<string> {"bark", "growl", "yip", "whine", "Whoof"};
    List<string> bodyFeatures = new List<string> {"feet", "fur", "tail"};
    private List<string> vocalsHappy = new List<string> {"bark", "Whoof"};
    private List<string> vocalsUnhappy = new List<string> {"growl", "yip", "whine"};
    private Random rand = new Random();


    public Dog(string name, string color) : base()
    {
        _petType = "dog";
        _name = name;
        _color = color;
        
        //add movements for this type        
        AddMovements(strMovement); //can also be added through a list of strings

        //add interactions for this type       
        AddInteractions(interactions);

        //add vocalizations for this type        
        vocalizations.AddRange(vocalsHappy);
        vocalizations.AddRange(vocalsUnhappy);
        ReplaceVocalizations(vocalizations);

        //add body features for this type        
        AddBodyFeatures(bodyFeatures);
       
    }

     public override string Happy()
     {  //can override for each pet type depending on it's abilities
        List<string> happyList = new List<string> {"jump", "tail wagg"};
        happyList.AddRange(vocalsHappy);    //add happy vocals
        int randomNum = rand.Next(happyList.Count);
        
        return "Your " + _petType + " is " + happyList[randomNum] + "ing"; ////e.g. "Your dog is " + Happy() = Your dog is smiling
    }

    
}