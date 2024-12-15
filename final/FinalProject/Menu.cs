using System;

public class Menu{

    private List<Pet> petList = new List<Pet>();
    private Animation animation = new Animation();

    public void InitMenu(){//call this for when the program first starts up; user must have at least one pet
        Console.WriteLine("Please create a pet:");
        Pet pet = new Pet();//just because program still needs a pet
        pet = CreateNewPet(); //menu and creates new pet
        Console.WriteLine(pet.GetPetInfo() + "\n");
    }


    public bool MainMenu(){//call this after they have created at least one pet.
        bool quitProgram = false;   //set to false until user chooses quit; then true
        Pet pet = new Pet();//just because program still needs a pet

        GetTotalPoints();
        Console.WriteLine("-------- Main Menu --------");
        Console.WriteLine("1. Create a new pet.");
        Console.WriteLine("2. Interact with your pet");
        Console.WriteLine("3. List your pets.");
        Console.WriteLine("4. Quit");
        Console.Write("Choose an option:  ");
        int iChoice = int.Parse(Console.ReadLine());
        switch(iChoice){
            case 1: //1. Create a new pet.
                pet = CreateNewPet(); //menu and creates new pet
                Console.WriteLine(pet.GetPetInfo() +"\n");
                break;
            case 2: //2. Interact with your pet
                InsteractMenu();
                break;
            case 3: //3. List your pets.
                ListPets(false);    //just list pets; they don't select from them
                break;
            case 4:     //quit program
                quitProgram = true;
                break;
            default: //entry not recognized
                Console.WriteLine("Input not recognized. Please try again. \n");
                break;
        }
        Console.WriteLine();//empty line
        return quitProgram;
        
    }


    //MAIN MENU METHODS
    //1. Create a new pet.
    protected Pet CreateNewPet(){

        int idxNewPet;
        //MENU
        Console.WriteLine("Create a new pet from the following types:");
        List<string> listTypes = new List<string> {"Dog", "Cat", "Bird", "Hamster", "Fish"};

        for (int idx = 0; idx < listTypes.Count; idx++){
            Console.WriteLine(idx+1 + ". " + listTypes[idx]);
        }

        Console.Write("Choose a type: ");
        string strType = Console.ReadLine();
        strType = listTypes[int.Parse(strType)-1].ToLower();
        Console.Write("What is the name of your " + strType +"? ");                                            
        
        string strInName = Console.ReadLine();
        Console.Write($"What color is {strInName}: ");
        string strInColor = Console.ReadLine();


        //CREATE PET
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
        }//end switch

        idxNewPet = petList.Count-1;
        Console.WriteLine("Your " + petList[idxNewPet].Type + " says " + petList[idxNewPet].Speak() + ".");

        return petList[idxNewPet];

    }


    //2. INTERACT with your pet MENU
    public void InsteractMenu()
    {
        Console.WriteLine("\nLet's interact with a pet:");
        int iChoice = ListPets(true);   //outputs menu and gets selection
        Pet selectedPet = petList[iChoice]; //get the pet
        Console.WriteLine("\n" + selectedPet.GetPetInfo()); //output selection

        //interact with pet
        animation.InteractWithPet(selectedPet);

        //do you want to interact with this pet again?
        while (true)
        {
            animation.PauseWithSpinner();
            Console.Write("\nDo you wnat to interact with this pet again? (Y/N): ");
            string continueChoice = Console.ReadLine().ToUpper();
            if (continueChoice != "Y")  //exit if not (Y)es
            {
                break;
            }
            //If (Y)es then let them interact again
            animation.InteractWithPet(selectedPet);

        }

    }  //end menu



    //3. List your pets MENU
    public int ListPets(bool IsUserSelecting){//Can Reuse to select a pet by changing arg to true
        int iSelect = 0;
        Console.WriteLine("\nHere are your pets and their points: ");
        for (int idx = 0; idx < petList.Count; idx++){
            iSelect = idx + 1;
            Console.WriteLine($"{idx + 1}.  {petList[idx].Name}   ({petList[idx].Color} {petList[idx].Type}):  {petList[idx].Score} total points.");
            // Console.WriteLine(" Score: " + petList[idx].Score);    //endline with score
        }
        if (IsUserSelecting){//user is selecting from the list then get their entry; else iSelect = 0
            Console.Write("Choose a pet to interact with (by number): ");
            iSelect = int.Parse(Console.ReadLine()) -1;
        }
        Console.WriteLine();    //empty line
        GetTotalPoints();
        animation.PauseWithSpinner(9);        

        return iSelect;

    }

    public void GetTotalPoints()
    {
        int totalScore = 0;
        for (int i = 0; i < petList.Count; i++)
        {
           totalScore += petList[i].Score;
        }
        Console.WriteLine($"Your total score is: {totalScore.ToString()}");

    }

}