// See https://aka.ms/new-console-template for more information
Console.WriteLine("Methods using reference type data");

// this declares an array of size 10 and is initialized to the default of the datatype
int[] numbers = new int[10];

//this declares an array of size 10 AND initializes each element to
//  a coresponding value.
//the size of the array is set by the numbers of supplied values
//int[] numbers = new int[] { 3,3,3,3,4,4,5,6,1,1};

int logicalSize = 0;

logicalSize = GetArrayValues(numbers);

DisplayValues(numbers,logicalSize);

static int GetArrayValues(int[] mynums)
{
 //the parameter is a reference type variable
 //reference type variables are really an address that is pointing to the actual data
 //therefore, when passing a reference type variable it is NOT a copy, it IS the location
 //     of the actual data from the drive code
 //THEREFORE any changes to the local variable (containing the address of the actual data)
 //     will result in changes to the ORIGINAL data
 //you can assume that the parameters is a two way variable
 //THUS any local change to the reference variable will be available to the drive program
 //     when you return to the calling statement
    Random rnd = new Random();
    int logicalSize = 0;
    for (int i = 0; i < 10; i++)
    {
        int newnum = rnd.Next(1, 11);
        if (newnum % 2 == 0)
        {
            mynums[logicalSize] = newnum;
            logicalSize++;
        }
    }
    return logicalSize;
}

static void DisplayValues(int[] mynums, int logicalSize)
{
    for (int i = 0; i < logicalSize; i++)
    {
        Console.WriteLine($"Element at {i} is {mynums[i]}");
    }
}

