using System;

public class Gamification
{
    private Random random;
    List<string> kudos;




    public Gamification()
    {
        kudos = new  List<string>
        {
            "You deserve a treat today!",
            "Way to go!",
            "You are doing great!",
            "Congrats!",
            "Give yourself a pat on the back!! :)",
            "Awesome job!!",
            "Take some time to give yourself accolades. You Earned it!!",
            "Be proud of your progress! Keep it up!",
            "One more step on the path :)",
            "You deserve some Me Time! Go have some fun!"
        }; 
        random = new Random();
    }

    public string GetRandomPrompt()
    {
        int randomNum = random.Next(kudos.Count); // generate a random index for list 'kudos'
        return kudos[randomNum];
    }

}