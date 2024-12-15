using System;


class Program
{
    static void Main(string[] args)
    {
        
        Animation animation = new Animation();
        Menu menu = new Menu();
        
        //on start:
        //describe the program and what it does
        Console.Clear();
        Console.WriteLine("\n\nThis program allows you to create pets and interact with them");
        Console.WriteLine("The more you interact with your pets the greater your rewards!\n");
        animation.PauseWithSpinner(5);
        

        //then user must create a new pet
        //after they create their first pet give them the full menu
        menu.InitMenu();    //only allows to create a pet
        Console.WriteLine("\nNow that you have a new pet. Let's see what you can do:\n");
        animation.PauseWithSpinner();
        
        
        //Main Menu
        bool quitProgram = false;    //don't quit when false   
        while (quitProgram==false){ //loop until user wants to quit
            Console.Clear();
            animation.PauseWithSpinner();
            quitProgram = menu.MainMenu(); //loops until false = quit        }
        } //end wile

        //ON QUIT:
        animation.PauseWithSpinner();
        Console.Write("Thanks for playing! Come again! \n\n");
    

    }  //end main
} //end class














