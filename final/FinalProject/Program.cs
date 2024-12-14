using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        string strType = "";
        string strInName = "";
        string strInColor = "";
        
        Animation animation = new Animation();
        List<Pet> petList = new List<Pet>();
        // List<string> strList;   //use for any list of strings as needed
        
        //Explain what you can do: e.g. This program allows you to create a pet and interact with it. By interacting with it you get points.
        
        //Menu
        Console.WriteLine("1. Create a new pet.");
        Console.WriteLine("2. Interact with your pet");
        Console.WriteLine("3. List your pets.");
        int mainMenuChoice = int.Parse(Console.ReadLine());

        switch (mainMenuChoice)
        {
            case 1: //create new Pet
                Console.WriteLine("Choose the type of pet you want to create.");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine("3. Bird");
                Console.WriteLine("4. Hamster");
                Console.WriteLine("5. Fish");
                Console.Write("Choose a type: ");
                strType = Console.ReadLine();
                switch (strType)
                {
                    case "1":
                        strType = "dog";
                        break;
                    case "2":
                        strType  = "cat";
                        break;
                    case "3":
                        strType  = "bird";
                        break;
                    case "4":
                        strType  = "hamster";
                        break;
                    case "5":
                        strType  = "fish";
                        break;
                    default:
                        break;

                }
                Console.WriteLine($"What is the name of your {strType}? ");
                strInName = Console.ReadLine();
                Console.Write($"What color is {strInName}: ");
                strInColor = Console.ReadLine();
                break;

           // case 2:


        }
       
    
               
        switch (strType){
            case "dog":     //dog
                Dog dog = new Dog(strInName, strInColor);                
                petList.Add(dog);                
                break;
            case "cat":     //cat
                Cat cat = new Cat(strInName, strInColor);               
                petList.Add(cat);               
                break;
            case "bird":     //bird
                Bird bird = new Bird(strInName, strInColor);                
                petList.Add(bird);                 
                break;
            case "hamster":     //hamster
                Hamster hamster = new Hamster(strInName, strInColor);               
                petList.Add(hamster);                 
                break;
            case "fish":     //fish
                Fish fish = new Fish(strInName, strInColor);                 
                petList.Add(fish);                  
                break;
            default:
                //do something
                break;
        }//end switch

        while (true)
        {
            animation.MenuIO(petList);
            
            Console.WriteLine("\nDo you wnat to interact with another pet? ");
            string continueChoice = Console.ReadLine().ToLower();
            if (continueChoice != "y")
            {
                break;
            }
        }
         
    } //end main

    

} //end class



//----classes----
//Problem - description, root cause(can have more than 1), score
//Categories or group - score
//take action - 
//task - name, minTime, cumulative time, times accomplished
//rewards - increase with each task accomplished
// animation -
//filein / fileout - 
//report - check progress











// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello FinalProject World!");
//     }
// }