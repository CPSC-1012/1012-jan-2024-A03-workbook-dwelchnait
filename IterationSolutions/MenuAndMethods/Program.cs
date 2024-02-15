// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
//
//start of the main driver code
//
Console.WriteLine("\nUsing Various loop structures\n");

//an example of using a menu to determine which example to execute
//post-test loop
string menuChoice = "";

//a menu displays to the user a number of selection to choose from
//the user makes a selection and the program executes the selection
//since the user must make at least on choice, the logic will
//  be executed at least once
//this is an opportunity for using the post-test loop
do
{
    // display the menu choices
    Console.WriteLine("\nA: Pre-Test Loop sample");
    Console.WriteLine("B: Post-Test Loop sample");
    Console.WriteLine("C: Pre-Test Counter Loop sample");
    Console.WriteLine("D: Search string for character");
    Console.WriteLine("X: Exit");
    Console.Write("Enter your choice:\t");
    menuChoice = Console.ReadLine();
    //menuchoice needs to be tested against a single value
    //  in an equals relationship to determine what to execute
    //this lis an opportunity to use the case descision structure
    switch(menuChoice.ToUpper())
    {
        case "A":
            {
                //call the method to execute by stating its name
                SimplePreTestLoop();
                break;
            }
        case "B":
            {
                //call the method to execute by stating its name
                SimplePostTestLoop();
                break;
            }
        case "C":
            {
                SimpleCounterLoop();
                break;
            }
        case "D":
            {
                CharacterSearch();
                break;
            }
        case "X":
            {
                Console.WriteLine("\n\nyou choice item X\n");
                break;
            }
        default:
            {
                Console.WriteLine($"\n\nyour choice of {menuChoice} is invalid. Try again\n");
                break;
            }
    }
} while (!(menuChoice.ToUpper().Equals("X")));

//
//end of the main driver code and your program
//

//Methods

//a method is a coding block that can be code in isolation from
//  the rest of your program BUT remains part of the program
//to execute the method, you call the method by name
//the method will execute from the start of the method to the
//  end of the method
//after execution, program control returns to where the method
//  was called

void SimplePreTestLoop()
{
    //read in numbers while the number is not 0
    int num = 0;
    string inputValue = "";
    Console.Write("\tEnter a number, use 0 to terminate;\t");
    inputValue = Console.ReadLine();
    num = int.Parse(inputValue);

    //loop
    //pre-test is to ask the loop condition question BEFORE entering
    while (num != 0)
    {
        Console.WriteLine($"You entered the number:\t {num}");

        //repeat the code to get the next number
        Console.Write("\tEnter a number, use 0 to terminate;\t");
        inputValue = Console.ReadLine();
        num = int.Parse(inputValue);
    }
}

void SimplePostTestLoop()
{
    //read in numbers while the number is not 0
    int num = 0;
    string inputValue = "";
    //loop
    //post-test is to ask the loop condition question AFTER executing
    //  the loop code at least once
    do
    {
        Console.Write("\tEnter a number, use 0 to terminate;\t");
        inputValue = Console.ReadLine();
        num = int.Parse(inputValue);

        //IF you do NOT wish the processing logic to execute
        //you WILL need to test for the termination condition

        if (num != 0)
        {
            Console.WriteLine($"You entered the number:\t {num}");
        }
    } while (num != 0);
}

void SimpleCounterLoop()
{
    //demonstration the for loop
    //the for loop is referred to as a counter loop structure
    //we could duplicate the process using a while loop
    //syntax:   for(initialize area; loop condition(s); increment area) { ... }

    //count the coinage change you have in your pocket
    string inputValue = "";
    int numberOfCoins = 0;
    double sumOfChange = 0.0;
    string coinType = "";
    //nickles,dimes,quarters,loonies,toonies
    for(int counter=1; counter <= 5; counter++)
    {
        coinType = counter == 1 ? "nickels" :
                    counter == 2 ? "dimes" :
                    counter == 3 ? "quarters" :
                    counter == 4 ? "loonies" : "toonies";

        Console.Write($"Enter the number of {coinType} you have:\t");
        inputValue =Console.ReadLine();
        numberOfCoins = int.Parse(inputValue);
        sumOfChange += counter == 1 ? numberOfCoins * 0.05 :
                    counter == 2 ? numberOfCoins * 0.10 :
                    counter == 3 ? numberOfCoins * 0.25 :
                    counter == 4 ? numberOfCoins * 1.00 : numberOfCoins * 2.00;
    }
    Console.WriteLine($"You have ${sumOfChange.ToString("#,##0.00")} in change,");
}

void CharacterSearch()
{
    string searchString = "";
    char searchCharacter = ' ';
    int timesFound = 0;
    Console.Write("Enter the character string to search:\t");
    searchString = Console.ReadLine();
    Console.Write("Enter character for which to search:\t");
    searchCharacter = char.Parse(Console.ReadLine());
    //
    // how long is the string? 
    //      there is a set of properties that belong to the
    //      string to which the coder has access: .Length
    // how can on examine a single character in a string
    //      there is a set of methods that belong to the
    //      string of which the coder can use: .SubString(index, length)
    //C# frequently uses 0 based indexing to location items
    //  within the C# data structure
    //For a string you can access a specific character via its position
    //  within the string using the index

    //              she sells seashells by the sea shore
    //natural count 12345678....
    //indexing      01234567....

    int stringLength = searchString.Length; //number of natural count characters
    for(int index = 0; index < stringLength;index++)
    {
        if (char.Parse(searchString.Substring(index,1)) == searchCharacter)
        {
            timesFound++;
        }
    }
    Console.WriteLine($"\n\nYour character {searchCharacter} appears" +
        $" {timesFound} in your string.");
}