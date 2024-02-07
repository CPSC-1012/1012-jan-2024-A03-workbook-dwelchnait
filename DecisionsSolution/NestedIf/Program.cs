// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tGames! Games! Games!\n");

string inputValue;
Random rdn = new Random();
int machineChoice;
int userChoice;

machineChoice = rdn.Next(0, 3);

Console.WriteLine("Choices: Scissor (0), Rock (1), Paper (2)");
Console.Write("Enter the number representing your choice:\t");
inputValue = Console.ReadLine();
//userChoice = int.Parse(inputValue); //could aboort program if input is not a number
//validating your input
//
// use a version of parsing that checks if you are successful
//      in converting your string to your desired datatype
// syntax:     datatype.TryParse(string, out receivingvariable)
//  where datatype is the desired data type
//        string is the data to be converted
//        receivingvariable is where the converted data will be placed
//        returns a boolean true is converted plus the converted data
//                      OR  false if not converted and the default of the rv datatype
if(int.TryParse(inputValue, out userChoice))
{
   
    //check if the number is a valid choice
    //
    // have an if structure within an existing if structure
    // this is known as a "nested if"

    //How to handle multiple conditions on a if statement
    //
    //there is another set of operator which are your "Logical" operators
    // these operators are and (&&), or (||), not !(condition)
    // these operators are used to join multiple conditions on an "if" statement
    //
    //  Truth Tables
    //
    //   condition A   B   result  comment
    //    AND      T   T     T     both conditions MUST be true
    //             T   F     F     one of the conditions is NOT true
    //             F   T     F     one of the conditions is NOT true
    //             F   F     F     one of the conditions is NOT true
    //
    //     OR      T   T     T     one of the conditions is true
    //             T   F     T     one of the conditions is true
    //             F   T     T     one of the conditions is true
    //             F   F     F     both conditions MUST be false
    //if (userChoice == 0 || userChoice == 1 || userChoice == 2)
    if (userChoice >= 0 && userChoice <= 2)
    {
        // a valid choice
        Console.WriteLine($"Your input of {userChoice} is a valid choice.");
    }
    else
    {
        // not a valid choice
        Console.WriteLine($"Your input of {userChoice} is not an acceptable choice.");
        //program should terminate
    }
}
else
{
    Console.WriteLine($"Your input of {inputValue} is not number.");
    //program should terminate
}
