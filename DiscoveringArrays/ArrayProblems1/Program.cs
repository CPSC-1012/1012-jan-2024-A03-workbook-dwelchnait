// See https://aka.ms/new-console-template for more information
using System.Dynamic;

Console.WriteLine("Array Problems Exercise 1");

//Problem1(); //calls the code in the method named Problem1
Problem2(); //calls the code in the method named Problem1

//Problem solutions
void Problem1() //method
{
    // 1. Create a program that will allow the user to enter up to 25 numbers
    // into an array.  Calculate and display the mean average of the numbers. 

    /*
     * Declare array nums as int (25)
     * Declare inputValue as string
     * Declare countOfNums as int
     * Declare exitLoop as bool
     * Declare runningSum as int
     * Loop (while countOfNums < 25 or exitLoop
     *    Prompt/Read number
     *    Store in array if not exit number
     *    Add to running sum
     * Calculate average
     * Display average and individual numbers
     */
    const int arraySize = 5;
    int[] nums = new int [arraySize];
    string inputValue = "";
    int inputNum = 0;
    int countOfNums = 0;
    bool exitLoop = false;
    int runningSum = 0;
    double numAverage = 0;
    //user friendly error handling
    try
    {
        do
        {
            Console.Write("Enter a positive whole number:\t");
            inputValue = Console.ReadLine();
            if (int.TryParse(inputValue, out inputNum))
            {
                nums[countOfNums] = inputNum;
                runningSum += inputNum;
                //remember to count the actual number of nums entered
                countOfNums++;
            }
            else
            {
                exitLoop = true;
            }
        } while (!exitLoop); //no max range test for array size
                             //} while (countOfNums<arraySize && !exitLoop) ;
    }
    catch (IndexOutOfRangeException ex) //specific catch for the error type
    {
        Console.WriteLine($"Array index Error: {ex.Message}");
    }
    catch(Exception ex) //generic catch all exceptions
    {
        Console.WriteLine($"System Error: {ex.Message}");
    }
//calculate average
if (countOfNums > 0)
    {
        //to temporarily change the datatype of a variable you can use
        //  what is referred to as "casting"
        //syntax (datatype)variable

        numAverage = (double)runningSum / (double)countOfNums;
    }
    Console.Write($"Your average is {numAverage} from the set of values: ");
    for(int i = 0; i < countOfNums; i++)
    {
        Console.Write($"{nums[i]} ");
    }
}//return to the call statement

void Problem2() //method
{
    // Create a program that will allow the user to enter up to 25 names and
    // marks into a set of parrallel arrays.
    // Calculate and display the mean average of the marks.
    // Find the Highest Mark
    // Find the Lowest Mark

    /*
     * Declare array marks as int (25)
     * Declare array names as string (25)
     * Declare inputValue as string
     * Declare logicalSize as int  -- the number of elements filled in the array
     * Declare exitLoop as bool
     * Declare runningSum as int
     * Loop (while logicalSize < array size or exitLoop
     *    Prompt/Read a name
     *    Store in array if not exit value (x)
     *    Prompt/Read mark
     *    Store in array if not exit condition
     *    Add to running sum
     * Calculate average
    
     * Display the average
     * Find and Display the Highest mark
     * Find and display the lowest mark
     * Display student name and mark
     */
    const int arraySize = 25; //phyiscal size
    int[] nums = new int[arraySize];
    string[] studentNames = new string[arraySize];
    string inputValue = "";
    int inputNum = 0;
    int logicalSize = 0;
    bool exitLoop = false;
    int runningSum = 0;
    double markAverage = 0;
    //user friendly error handling
    try
    {
        do
        {
            Console.Write("Enter the student name (use x to terminate student list) \t");
            inputValue = Console.ReadLine();
            if (inputValue.ToUpper().Equals("X"))
            {
                exitLoop = true;
            }
            else
            {
                studentNames[logicalSize] = inputValue;
                Console.Write("Enter a positive whole number (0-100):\t");
                inputValue = Console.ReadLine();
                if (int.TryParse(inputValue, out inputNum))
                {
                    nums[logicalSize] = inputNum;
                    runningSum += inputNum;
                    //remember to count the actual number of nums entered
                    logicalSize++;
                }
            }
        //} while (!exitLoop); //no max range test for array size
        } while (logicalSize < arraySize && !exitLoop) ;
    }
    catch (IndexOutOfRangeException ex) //specific catch for the error type
    {
        Console.WriteLine($"Array index Error: {ex.Message}");
    }
    catch (Exception ex) //generic catch all exceptions
    {
        Console.WriteLine($"System Error: {ex.Message}");
    }
    //calculate average
    if (logicalSize > 0)
    {
        //to temporarily change the datatype of a variable you can use
        //  what is referred to as "casting"
        //syntax (datatype)variable

        markAverage = (double)runningSum / (double)logicalSize;
    }
    Console.WriteLine($"Student average is {markAverage}");
    //finding the highest mark
    int highestMark = 0;
    int lowestMark = 100;
    for (int i = 0; i < logicalSize; i++)
    {
        if (nums[i] > highestMark)
        {
            //there is a new highest mark
            highestMark = nums[i];
        }
        if (nums[i] < lowestMark)
        {
            //there is a new lowest mark
            lowestMark = nums[i];
        }
    }
    Console.WriteLine($"Student highest mark is {highestMark}");
    Console.WriteLine($"Student lowest mark is {lowestMark}");

}//return to the call statement

