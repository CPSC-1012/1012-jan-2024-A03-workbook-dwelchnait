// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Collective\n\n");

//a single variable
int grade = 78;

//a collection of integers representing a collection of marks
// the size of the collection is 33 
// this means the array can hold up to 33 values
// each value is an integer
//syntax   datatype [] arrayname = new datatype[size];
int[] grades = new int[33];

//randomly assign 33 grades to this arrays
Random rdn = new Random();

//traverse the array filling in each element with a
//  random value between 0 and 100 inclusive

for(int index = 0; index < grades.Length; index++)
{
    grades[index] = rdn.Next(0, 101);
}

for (int index = 0; index < grades.Length; index++)
{
    Console.WriteLine($"The grade at index of {index}" +
        $" is {grades[index]}");
}

