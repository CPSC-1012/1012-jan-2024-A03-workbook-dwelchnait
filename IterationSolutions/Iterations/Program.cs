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
bool validFlag = false;
int loopCounter = 0;

//continue to prompt for a valid number until the user
//  enters a valid number

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

if (validFlag)
{
    // loop x number of times equal to the value supplied by the user
    //we will use the PRE-Test loop while to accomplish this task
    //syntax:   while(condition) { ...coding block ...}
    while (loopCounter <= numberOfIterations)
    {
        //sumOfSquares = sumOfSquares + (loopCounter * loopCounter);
        sumOfSquares += (loopCounter * loopCounter);

        //increment the loopCounter to indicate the number of times
        //  one has gone through the loop
        //loopCounter = loopCounter + 1;
        //loopCounter += 1;
        loopCounter ++;  //single unit increment of variable + 1s
                         //increment after use
        ++loopCounter;   //increment before use

    }

    Console.WriteLine($"The sum of squares for {numberOfIterations} is {sumOfSquares}");
}


//Exercise problems 1 question 2

int aNumber = 0;
int sumOfNumbers = 0;
int countOfNumbers = 0;
double avgOfNumbers = 0.0;

//this code needs to be done at least once
//the loop structure for this solution will use the POST-Test condition
//syntax:    do{ ...coding block ...} while(condition(s));

do
{
        Console.Write("Enter a positive whole number:\t");
        inputValue = Console.ReadLine();
        aNumber = int.Parse(inputValue);
   
    if (aNumber > 0)        //do not count the exit number as part of the summing
    {
        sumOfNumbers += aNumber;
        countOfNumbers++;
    }
} while (aNumber > 0);

avgOfNumbers = sumOfNumbers / countOfNumbers;
Console.WriteLine($"The average of your {countOfNumbers} number(s) is {avgOfNumbers}");
