using System;

public class Animation
{
    private string[] _clockAnimationString = {"|", "/", "-", "\\", "|", "-", "\\"};
    private Random randSpeak = new Random();
    
    public Animation()
    {

    }

    public void OutputBodyFeatures(List<string> features){
        Console.WriteLine();    //empty line
        Console.WriteLine("Here are some body features your pet has:");  
        // features.ForEach(Console.WriteLine);  //works with string arrays too! puts out on sepearate lines
        //alternative to add more characters
        Console.WriteLine(String.Join(", ", features));  //Outputs each with a ", " in between on 1 line
        Console.WriteLine();    //empty line
    }  //end output

    public void GetInteraction(List<string> interactions){
        int iChosen;
        Console.WriteLine();    //empty line
        Console.WriteLine("Let's interact with your pet. Here are your options:");  
        for (int idx = 0; idx < interactions.Count; idx++){ //write all options in list
            Console.WriteLine((idx+1) + ". " + interactions[idx].ToString());
        } //end loop through list
        
        //Ask user how they want to interact with their pet
        Console.Write("Please choose an interaction by number: ");
        iChosen = int.Parse(Console.ReadLine())-1;

        //output choice
        Console.WriteLine("\nYou chose to " + interactions[iChosen].ToString() + ".");
        Console.WriteLine("You just made your pet very happy!");
        
    } //end output

    public void OutputVocalizations(List<string> vocalizations){
         Console.WriteLine();    //empty line
        Console.WriteLine("Here are some vocalizations pet has:");  
        // vocalizations.ForEach(Console.WriteLine);  //works with string arrays too! puts out on sepearate lines
        //alternative to add more characters
        Console.WriteLine(String.Join(", ", vocalizations));  //Outputs each with a ", " in between on 1 line
        Console.WriteLine();    //empty line
    }

    public void GetPoints(Pet pet)
    {
        Console.WriteLine($"You have {pet.Score} total points for this pet.");
    }
    public void PauseWithSpinner()
    {
        PauseWithSpinner(4);
    }

    public void PauseWithSpinner(int numSeconds)
    {
        DateTime startAnimation = DateTime.Now;
        DateTime stopAnimation = startAnimation.AddSeconds(numSeconds);
        int i = 0;
        while (DateTime.Now < stopAnimation)
        {
            Console.Write(_clockAnimationString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _clockAnimationString.Count())
            {
                i=0;
            }
        }
    }
    
    public string RandomTalkBack(List<string> vocalizations)
    {
        int randomNum = randSpeak.Next(vocalizations.Count);
        return vocalizations[randomNum];
    }

    public void MenuIO(Pet pet)
    {
        Console.WriteLine("\n" + pet.GetPetInfo());
        PauseWithSpinner(3);
        GetInteraction(pet.Interactions);
        pet.InteractForPoints();
        Console.WriteLine($"You earned {pet.CurrentPoints} points.");
        GetPoints(pet);
    }
}