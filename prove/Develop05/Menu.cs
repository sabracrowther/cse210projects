using System;

public class Menu 
{

    //todo::
    //clean up output text. make pretty :)    
    //watch video: does it spit back the list after create new?
    //gamification addons <- LAST


     //create a list of goal objects
    public static List<Goal> goalList = new List<Goal>();
    public static int totalCumulativePoints = 0;

    
    

    public static int MainMenu()
    {
        Gamification gamification = new Gamification();

        //call menu
        Console.WriteLine("");
        Console.WriteLine($"You have {totalCumulativePoints} points. ");
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal ");
        Console.WriteLine("2. List Goals ");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");


        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: // create new goal
                
                Console.WriteLine("The types of goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                //depending on the choice call a function to give them the menu options associated with each goal type
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        //simple call
                        AddSimple();
                        break;
                    case 2:
                        //eternal call
                        AddEternal();
                        break;
                    case 3:
                        //checklist call
                        AddChecklist();
                        break;
                    default:
                        //not an option output
                        break;
                }
                break;
            case 2: //list goals
                Console.WriteLine("");
                Console.WriteLine("You can choose from the following: ");
                Console.WriteLine("1. List only Open goals. ");
                Console.WriteLine("2. List only Completed goals. ");
                Console.WriteLine("3. List All goals. ");
                Console.Write("Which goals would you like listed? ");
                int goalStatus = int.Parse(Console.ReadLine());
                
                switch (goalStatus)
                {
                    case 1://open
                        listGoals("open");
                        break;
                    case 2: //completed
                        listGoals("completed");
                        break;
                    case 3: //all
                    default:
                        listGoals("all");
                        break;

                }                
                break;
            case 3:     //save goals to file
                PipeDelimitedExport();
                break;
            case 4:     //load goals from file
                ImportFromFile();
                break;
            case 5: //record event
                Console.WriteLine("Select a goal to record from the list:");
                listGoals("open");
                Console.Write("Which goal did you accomplish? ");
                int listIndex = int.Parse(Console.ReadLine()) -1; //get the index of the list
                //update points                
                int pointsEarned = goalList[listIndex].RecordEventPoints(); 
                totalCumulativePoints = totalCumulativePoints + pointsEarned;
                string str = gamification.GetRandomPrompt();
                Console.WriteLine(str);

                break;
            case 6: //quit
                break;  
            default: 
                Console.WriteLine("This is not a valid option. Please try again.");
                break;
        
        }
        return choice;
    }

    private static void AddEternal()
    {
        EternalGoal e = new EternalGoal();
        e = e.CreateNew();
       
        goalList.Add(e);
        Console.WriteLine(e.ListGoal());
        Console.WriteLine($"Congratulations! New {e.GetGoalType()} goal created!!");
    }

    private static void AddSimple()
    {
        SimpleGoal s = new SimpleGoal();
        s = s.CreateNew();
       
        goalList.Add(s);
        Console.WriteLine(s.ListGoal());
        Console.WriteLine($"Congratulations! New {s.GetGoalType()} goal created!!");
    }

    private static void AddChecklist()
    {
        Console.WriteLine("You chose Checklist goal.");
        ChecklistGoal c = new ChecklistGoal();
        c = c.CreateNew();
       
        goalList.Add(c);
        Console.WriteLine(c.ListGoal());
        Console.WriteLine($"Congratulations! New {c.GetGoalType()} goal created!!");
    }

    private static void listGoals()
    {
        Console.WriteLine("The goals are: ");
        foreach(Goal goalObject in goalList)
        {             
            Console.WriteLine((goalList.IndexOf(goalObject)+1) + ". " +  goalObject.ListGoal());
           
        }
         
    }

    private static void listGoals(string goalStatus)//open, completed, all 
    {
        

        //switch case oppen, completed, all
        // eternal always open; need to check if completed for simple and checklist  
        switch (goalStatus)
        {
            case "open"://is not complete
                Console.WriteLine("The " +  goalStatus + " goals are: ");
                foreach(Goal goalObject in goalList)
                { 
                    
                    if (goalObject.IsComplete()==false) 
                    {
                        Console.WriteLine((goalList.IndexOf(goalObject)+1) + ". " +  goalObject.ListGoal());
                    } 
                }
                break;
            case "completed": //is complete
                Console.WriteLine("The " +  goalStatus + " goals are: ");
                foreach(Goal goalObject in goalList)
                {
                    if (goalObject.IsComplete()==true)
                    {
                        Console.WriteLine((goalList.IndexOf(goalObject)+1) + ". " +  goalObject.ListGoal());
                    }
                    
                }
                break;
            case "all":
            default: //output all regardless of if complete or not
                listGoals();
                break;
        }
        //all
            
    }

    private static void PipeDelimitedExport()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // first line is the total points
            outputFile.WriteLine(totalCumulativePoints);
            
            // You can use the $ and include variables just like with Console.WriteLine
            foreach(Goal goalObject in goalList)
           {
                outputFile.WriteLine(goalObject.PipeDelimitedOutput());
           }
           
        }

        
    }

    private static void ImportFromFile()
    {   
        Console.Write("What is the name for the goals file? ");
        string fileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string goalType = "";
        string strToParse = "";

        totalCumulativePoints = int.Parse(lines.First()); //get total points put them on the first line in the list
        goalList.Clear(); //empty program list to load as new list no duplicates or adds

        lines = lines.Skip(1).ToArray(); //total points line; deal with later

        foreach (string line in lines)
        {
            //for each line get the goal type, then parse it into a goal obj
            //get the type left of the colon and then the rest to parse from pipe delimiter
            goalType = "";
            strToParse = "";
            string[] parts = line.Split(":");
            goalType = parts[0];
            strToParse = parts[1];  

            //call class method to parse and assign variables correctly.
            //depending on the goal type call a parser to parse the data and create the object/goal new and add it to the list :)
            
            switch (goalType)
            {
                case "Simple":
                    //call parser and create object
                    SimpleGoal s = new SimpleGoal();
                    s = s.PipeDelimitedImport(strToParse);
                    //add to list of goals
                    goalList.Add(s);
                    break;
                case "Eternal":  
                    //call parser and create object                    
                    EternalGoal e = new EternalGoal();
                    e = e.PipeDelimitedImport(strToParse);
                    //add to list of goals
                    goalList.Add(e);
                    break;
                case "Checklist":
                    //call parser and create object
                    ChecklistGoal c = new ChecklistGoal();
                    c = c.PipeDelimitedImport(strToParse);
                    //add to list of goals
                    goalList.Add(c);
                    break;
                default:
                    //something
                    break;
            }
           
          
        }
        listGoals();

        
    }

        

}