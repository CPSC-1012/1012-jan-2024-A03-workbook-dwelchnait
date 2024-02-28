// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the Collective\n\n");

//a single variable
int grade = 78;

//a collection of integers representing a collection of marks
// the size of the collection is 33 
// this means the array can hold up to 33 values
// each value is an integer
//syntax   datatype [] arrayname = new datatype[size];

//Detail Plan
//Delcare array grades as Double (size 33)
//Declare rnd as Random (generate numbers)
//Loop (from index 0 t0 32)
//  generate a random number between 2600.00 and 2999.99
//  Set grades[indx] to number
//Loop (from index 0 to 32)
//  display grades[index]



double[] grades = new double[33];

//randomly assign 33 grades to this arrays
Random bob = new Random();

//traverse the array filling in each element with a
//  random value between 0 and 100 inclusive

for(int index = 0; index < grades.Length; index++)
{
    // grades[index] = bob.Next(2600,3000) +Math.Round(bob.NextDouble(),2);
    grades[index] = bob.Next(260000, 300000) /100.00; 

}

for (int index = 0; index < grades.Length; index++)
{
    Console.WriteLine($"The grade at index of {index}" +
        $" is {grades[index]}");
}

