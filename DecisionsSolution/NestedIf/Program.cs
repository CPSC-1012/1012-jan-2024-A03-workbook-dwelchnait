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

    //this validation is to determine if your data is within the
    //  appropriate domain (acceptable value)
    //if (userChoice == 0 || userChoice == 1 || userChoice == 2)
    if (userChoice >= 0 && userChoice <= 2)
    {
        // a valid choice
        Console.WriteLine($"Your input of {userChoice} is a valid choice.");

        //determine your flow of logic (critical path)

        if (userChoice == 0)
        {
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\nYou and the computer are both scissors. It is a draw");
            }
            if (machineChoice == 1)
            {
                Console.WriteLine("\n\nThe computer is a rock. You are scissors. You lose");
            }
            if (machineChoice == 2)
            {
                Console.WriteLine("\n\nThe computer is paper. You are scissors. You win");
            }
        }
        if (userChoice == 1)
        {
            //there is a modified structure for if/else that allows you to 
            //  execute one of a number of possible choices
            //this modified if/else structure is the if / else if /else
            if (machineChoice == 0)
            {
                Console.WriteLine("\n\nThe computer is scissors. You are rock. You win");
            }
            else if (machineChoice == 1)
            {
                Console.WriteLine("\n\nYou and the computer are both rocks. It is a draw");
            }

            else
            {
                Console.WriteLine("\n\nThe computer is a paper. You are rock. You lose");
            }
        }

        if (userChoice == 2)
        {
            //there is a structure reffered to as a case structure
            //conditions:
            //  a) there is a single argument to be check : machineChoice
            //  b) that argument is check against a series of values: 0,1,2
            //  c) the comparsion is EQUALS
            //
            //the C# command to use for a case structure is the switch
            //syntax:
            //      switch (argument)
            //      {
            //          case value:
            //          {
            //              C# logic to execute
            //              break;
            //          }
            //          .
            //          .
            //          .
            //          case value:
            //          {
            //              C# logic to execute
            //              break;
            //          }
            //          default:
            //          {
            //              C# logic to execute
            //              break;
            //          }
            //      }
            switch (machineChoice)
            {
                case 0:
                {
                    Console.WriteLine("\n\nThe computer is scissors. You are paper. You lose");
                        break;
                }
                case 1:
                {
                    Console.WriteLine("\n\nThe computer is a rock. You are paper. You win");
                    break;
                }
                default:
                {
                    Console.WriteLine("\n\nYou and the computer are paper. It is a draw");
                    break;
                }
            }//eos
        }//eof 15
        
    }
    else
    {
        // not a valid choice
        Console.WriteLine($"Your input of {userChoice} is not an acceptable choice.");
        //program should terminate
    }//eof 2
}//eof 1
else
{
    Console.WriteLine($"Your input of {inputValue} is not number.");
    //program should terminate
}
