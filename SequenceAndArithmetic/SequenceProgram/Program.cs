// See https://aka.ms/new-console-template for more information

//First Sequence Program exercise solution

//This program will input a name, age and salary then display in a statement to the
//  console display.

//Plan
//DECLARE myName as string
//DELCARE myAge as integer
//DELCARE mySalary as double

//Prompt for Name
//Read input
//SET myName to input
//Prompt for Age
//Read input
//SET myAge to input
//Prompt for Salary
//Read input
//SET mySalary to input

//DISPLAY Name, Age and Salary in a statement

string myName;  //assign a value directly at declaration time
int myAge;
double mySalary;
string inputValue; // a common variable to use to hold a input piece of data

//prompt for data
Console.Write("Enter your name:\t");
//input lines from the console are strings
myName = Console.ReadLine();

Console.Write("Enter your age:\t");
inputValue = Console.ReadLine();
//convert the strng to the appropriate datatype
myAge = int.Parse(inputValue);

Console.Write("Enter your expected salary:\t");
inputValue = Console.ReadLine();
//convert the strng to the appropriate datatype
mySalary = double.Parse(inputValue);

//practice formatting my salary
//.ToString("C2")
Console.WriteLine($"My name is {myName}, my age is {myAge} and I hope to earn {mySalary.ToString("C2")} per year");

//.ToString("#,##0.00")
//NOTE unlike the C format which automatically uses the $ when you take control, you have EVERYTHING
Console.WriteLine($"My name is {myName}, my age is {myAge} and I hope to earn {mySalary.ToString("#,##0.00")} per year");