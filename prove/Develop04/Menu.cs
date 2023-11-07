class Menu : Activity
{
    // display all the options for the user
    // once the user selects an option, display the description of the option
    private List<string> options = new()
    {
        "Breathing Activity",
        "Listing Activity",
        "Reflection Activity"
    };
    private List<string> optionDescs = new()
    {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    };

    public void WorkMenu()
    {
        DisplayOptions();
        UserSelection();
    }

    private void DisplayOptions()
    {
        for(int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}\n\t{optionDescs[i]}");
        }
    }
   private void UserSelection()
   {
    int selection = int.Parse(PromptUser("Please make a selection (Type the number): \n"));
    int userDurationTime = int.Parse(PromptUser("How long would you like to perform this activity? ")) * 1000;
    SetDuration(userDurationTime);

    switch(selection)
    {
        case 1:
            BreathingActivity breathingActivity = new(); // new instance of Breathing activity
            breathingActivity.Breathing(); // calls breathing function
            break;
        case 2:
            ListingActivity listingActivity = new(); // new instance of Listing activity
            listingActivity.Listing();
            break;
        case 3:
            // ReflectionActivity reflectionActivity = new(); // new instance of Reflection activity
            // do stuff
            break;
        default:
            Console.WriteLine("Thanks!");
            Environment.Exit(0); // Exits the program
            break;
    }
    
   }
}