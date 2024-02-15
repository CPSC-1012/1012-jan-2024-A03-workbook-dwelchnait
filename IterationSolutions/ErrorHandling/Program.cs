// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nWhat's happening. It's all wrong!!!!!\n");

//there will be times when something unexpected happens within 
//  your program which can cause your code to crash
//this is the last thing you want the user to experience

//what we wish to do is to gently handle this situation and
//  carefully land the user in a safe area
//this is often referred to as "user friendly error handling"
//most C#ers refer to it as simply Try/catch

//CRASH!!!!!!
int i = 5; 
int j = 0; 
//Console.WriteLine(i / j);

//check to see if you would divide by 0
//you can place code within your program to catch known expectly actions
//preventitive action
if(j != 0)
{
    Console.WriteLine(i / j);
}
else
{
    Console.WriteLine("You are attempting to divide by zero. This is wrong.");
}

//can we do the same with reactionary code
//this is where a try/catch comes into play
//try portion
//  this is the code you wish to attempt to execute
//  this code continues to execute until
//      a) complete
//      b) a system/program error occurs
//Catch portion
//  this code will execute IF the is a problem within the
//      try portion that would cause the program to crash

try
{
    //this is the code to attempt
    Console.WriteLine(i / j);
}
catch(Exception ex)
{
    //this is the code to execute if there is a system exception
    //by catching the exception, the program gently lands and continues
    //  to run
    //this code WILL NOT execute if the try code DOES NOT cause an
    //  exception
    Console.WriteLine($"System Error: {ex.Message}");
}

//could one do valid this way
//yes

//preventitive error handling
string inputValue = "";
int numberOfIterations = 0;
int sumOfSquares = 0;
bool validFlag = false;
int loopCounter = 0;

//continue to prompt for a valid number until the user
//  enters a valid number

Console.Write("\nPreventitive input handling\n");
while (!validFlag)
{
    //obtain the number of iterations
    Console.Write("Enter a positive number of squares to sum:\t");
    inputValue = Console.ReadLine();
    if (!int.TryParse(inputValue, out numberOfIterations))
    {
        Console.WriteLine($"Your entry of >{inputValue}< is not a integer number.");
        validFlag = false;
    }
    else if (numberOfIterations < 0)
    {
        Console.WriteLine($"Your entry of >{inputValue}< is a negative integer number.");
        validFlag = false;
    }
    else
    {
        validFlag = true; //will cause the loop to terminate
    }

}

//reactionary error handling
//reset flag to false
Console.Write("\nReactionary input handling\n");
validFlag = false;
while (!validFlag)
{
    try
    {


        //obtain the number of iterations
        Console.Write("Enter a positive number of squares to sum:\t");
        inputValue = Console.ReadLine();
        numberOfIterations = int.Parse(inputValue);
        if (numberOfIterations < 0)
        {
            Console.WriteLine($"Your entry of >{inputValue}< is a negative integer number.");
            validFlag = false;
        }
        else
        {
            validFlag = true; //will cause the loop to terminate
        }
        //if you reach the end of the try you are successful
        //  as far as the try/catch is concerned
        //continue to the code following the catch {...}
    }
    
    catch (Exception ex)
    {
        //this Exception is the global catch all exception for the system
        validFlag = false;
        Console.WriteLine($"Your entry of >{inputValue}< is not a integer number.");

    }
}
