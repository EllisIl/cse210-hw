class Menu
{
    int userPoints;
    List<string> menuOptions = new(){
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Event",
        "Quit"
    };
    List<string> goalTypes = new(){
        "Simple",
        "Eternal",
        "Checklist"
    };

    List<Goal> goalClasses = new(){
        new SimpleGoal(),
        new EternalGoal(),
        new ChecklistGoal(),
    };


    public void instantiateMenu(){
        Console.WriteLine($"You have {userPoints} points\n");

        Console.WriteLine("Menu Options:");
        for(int i = 0; i < menuOptions.Count; i++){
            Console.WriteLine($"\t{i+1}. {menuOptions[i]}");
        }
        Console.Write("Select a choice from the menu: ");
        int userChoice = int.Parse(Console.ReadLine());

        switch(userChoice){
            case 1:
                // Create New Goal
                createNewGoal();
                break;

            case 2:
                // List Goals
                printChecklist();
                break;

            case 3:
                // Save Goals
                break;
            case 4:
                // Load Goals
                break;
            case 5:
                // Record Event (complete goal)
                break;
            case 6:
                // quit
                break;
        }

    }

    void createNewGoal(){
        printGoals(goalTypes);
            Console.Write("Which type of goal would you like to create? ");

            int goalChoice = int.Parse(Console.ReadLine());

            switch(goalChoice){
                case 1:
                    // Simple Goal
                    Console.WriteLine(goalClasses[0]);
                    goalClasses[0].CreateGoal();
                    break;

                case 2:
                    // Eternal Goal
                    goalClasses[1].CreateGoal();
                    break;

                case 3:
                    // Checklist Goal
                    goalClasses[2].CreateGoal();
                    break;
            }
    }


    void printChecklist() {
        foreach(Goal goal in goalClasses){
            int goalLength = goal.GetGoalNames().Count;
            for(int i = 0; i < goalLength; i++){
                // if(!completed[i]){
                //     Console.WriteLine($"[ ] {goal.GetGoalNames()[i]}");
                // } else {
                //     Console.WriteLine($"[X] {goal.GetGoalNames()[i]}");
                // }
                    Console.WriteLine($"[X] {goal.GetGoalNames()[i]}");
            }
        }
    }
    void printGoals(List<string> goals) {
        Console.WriteLine("The types of Goals are: ");
        for(int i = 0; i < goals.Count; i++){
                Console.WriteLine($"\t{i + 1}. {goals[i]} Goal");
        }
    }
}