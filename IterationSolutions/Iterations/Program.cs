// See https://aka.ms/new-console-template for more information
Console.WriteLine("\n\tThis World is loopy!\n");

//Problem Exercise 1 Question 1

/*
 * Find the sum of the squares of the integers from 1 to MySquare, 
 * where MySquare is input by the user.  E.g. user enters 4 then 
 * return 1x1 + 2x2 + 3x3 + 4x4 = 30
 * 
 */

string inputValue;
int numberOfIterations = 0;
int sumOfSquares = 0;
bool validFlag = true;
int loopCounter = 0;

//obtain the number of iterations
Console.Write("Enter a positive number of squares to sum:\t");
inputValue = Console.ReadLine();
if (!int.TryParse(inputValue, out numberOfIterations))
{
    Console.WriteLine($"Your entry of >{inputValue}< is not a integer number.");
    validFlag = false;
}
else
{
    if (numberOfIterations < 0)
    {
        Console.WriteLine($"Your entry of >{inputValue}< is a negative integer number.");
        validFlag = false;
    }
}

if (validFlag)
{
    // loop x number of times equal to the value supplied by the user
    //we will use the PRE-Test loop while to accomplish this task
    //syntax:   while(condition) { ...coding block ...}
    while (loopCounter <= numberOfIterations)
    {
        sumOfSquares = sumOfSquares + (loopCounter * loopCounter);
        //increment the loopCounter to indicate the number of times
        //  one has gone through the loop
        loopCounter = loopCounter + 1;
    }

    Console.WriteLine($"The sum of squares for {numberOfIterations} is {sumOfSquares}");
}
