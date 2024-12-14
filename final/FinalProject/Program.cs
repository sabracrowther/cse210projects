using System;

class Program
{
    static void Main(string[] args)
    {
        string strType = "";
        string strInName = "";
        string strInColor = "";
        string makeNoise = "";
        Animation animation = new Animation();
        Pet pet = new Pet();
        // List<string> strList;   //use for any list of strings as needed
        
        //Explain what you can do: e.g. This program allows you to create a pet and interact with it. By interacting with it you get points.
        
        //Menu
        Console.WriteLine("Create a new pet.");
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
                Console.Write($"What is the name of your dog? ");
                break;
            case "2":
                Console.Write($"What is the name of your cat? ");
                break;
            case "3":
                Console.Write($"What is the name of your bird? ");
                break;
            case "4":
                Console.Write($"What is the name of your hamster? ");
                break;
            case "5":
                Console.Write($"What is the name of your fish? ");
                break;
            default:
                break;

        }
       
        strInName = Console.ReadLine();
        Console.Write($"What color is {strInName}: ");
        strInColor = Console.ReadLine();

        List<Pet> petList = new List<Pet>();
               
        switch (int.Parse(strType)){
            case 1:     //dog
                Dog dog = new Dog(strInName, strInColor);
                makeNoise = animation.RandomTalkBack(dog.Vocalizations);
                petList.Add(dog);
                Console.WriteLine($"\n'{makeNoise}' - {dog.GetPetInfo()}");
                animation.MenuIO(dog);
                break;
            case 2:     //cat
                Cat cat = new Cat(strInName, strInColor);
                makeNoise = animation.RandomTalkBack(cat.Vocalizations);
                petList.Add(cat);
                Console.WriteLine($"\n'{makeNoise}' - {cat.GetPetInfo()}");
                animation.MenuIO(cat);
                break;
            case 3:     //bird
                Bird bird = new Bird(strInName, strInColor);
                makeNoise = animation.RandomTalkBack(bird.Vocalizations);
                petList.Add(bird);
                Console.WriteLine($"\n'{makeNoise}' - {bird.GetPetInfo()}");
                animation.MenuIO(bird);
                break;
            case 4:     //hamster
                Hamster hamster = new Hamster(strInName, strInColor);
                makeNoise = animation.RandomTalkBack(hamster.Vocalizations);
                petList.Add(hamster);
                Console.WriteLine($"\n'{makeNoise}' - {hamster.GetPetInfo()}");
                animation.MenuIO(hamster);
                break;
            case 5:     //fish
                Fish fish = new Fish(strInName, strInColor);
                 makeNoise = animation.RandomTalkBack(fish.Vocalizations);
                petList.Add(fish);
                Console.WriteLine($"\n'{makeNoise}' - {fish.GetPetInfo()}");
                animation.MenuIO(fish);
                break;
            default:
                //do something
                break;
        }//end switch

        



        // Prompts prompts = new Prompts(); // create a new Prompts object
        
        // string prompt = prompts.GetRandomPrompt();  // get random prompt
        // Console.WriteLine(prompt);   // display random prompt
        // string _entryInput = Console.ReadLine();  //save new entry 

        // Entry newEntry = new Entry
        // {
        //     _date = DateOnly.FromDateTime(DateTime.Now),
        //     _prompt = prompt,
        //     _entry = _entryInput 
        // };

        // entries.Add(newEntry); //add the new entry to the list            
        

        // Console.WriteLine("\n\nTEST this, pet, etc.");
         
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