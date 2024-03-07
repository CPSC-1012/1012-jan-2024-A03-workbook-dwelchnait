// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Its a bunch of small Worlds (after all)!");

//discover the components of a method
//
//within the program you have 2 major areas:
// Driver
//    control the processing of the program
//    declares the data storage required in the progra
//    it calls any methods that are required to
//          complete the program process

// Methods
// individual coding components
// perform a single task
// called by the driver or by another method

//driver
//Calculator
//should be able to perform Addition, Subtration, Multiplication, Division
//should take two numbers from the user
//should allow the user to choose which operation to perform
//should display the input numbers, operation and result

int num1 = 0;
int num2 = 0;
double result = 0.0;
string choice = "";

//method call statement
//this method is commonly referred to as a function
//a fuction method is identified by the fact that a value is returned
//  from the method
//the returned value can be saved to a local variable (num1)
//the method is referred to on the call by the method name (GetIntegerNumber)
//this method is receiving a value (argument) via the call
num1 = GetIntegerNumber("Enter you first calucation number:"); 
num2 = GetIntegerNumber("Enter you second calucation number:");

//get the desired calculator operation
choice = GetCalculatorOperation();

//using the operator choice, perform the requested operation
switch (choice.ToLower())
{
    case "a":
        {
            result = Addition(num1, num2);
            Console.WriteLine($"The sum of {num1} + {num2} = {(int)result}");

            break;
        }
    case "s":
        {
            result = Subtraction(num1, num2);
            Console.WriteLine($"The difference of {num1} - {num2} = {(int)result}");

            break;
        }
    case "m":
        {
            result = Multiplication(num1, num2);
            Console.WriteLine($"The product of {num1} * {num2} = {(int)result}");

            break;
        }
    case "d":
        {
            //one should not divide by zero
            if ( num2 == 0)
            {
                result= 0.0;
                Console.WriteLine($"Division by zero is undefined.");
            }
            else
            {
                result = Division(num1, num2);
                Console.WriteLine($"The quotion of {num1} - {num2} = {result:#,##0.00}");
            }
          
          

            break;
        }
    default:
        {
            Console.WriteLine($"Your operator choice of >{choice}< is invalid");
            break;
        }
}
//end of driver

//Methods Area

//create a component of code to do a specific task
//Task: GetIntegerNumber
//receive a prompt line
//display the prompt line
//read the user input
//(validation should be included)
//return a integer value

//Method Header
// a) the return value
// b) methodname
// c) list of input parameters
//syntax::    rdt methodname ([list of parameters]) { coding block.. }

//rdt : single value
//      valid C# datatype
//      if method returns no value use the key word-> void

//methodname: program defined
//            should be meaningful
//            Pascal Case

//list of parameters: optional
//                    syntax: datatype parametername
//                    separate parameters with a comma ,

//RULE:
// the order of incoming parameters DICTATE the order of the arguments
//      on the call statement
// the argument/parameter pair MUST have the same datatype

//Is datatype IMPORTANT
//VAlUE type parameters receive a COPY of the argument value
//          WARNING any changes to the COPY will NOT be refected back
//                  in the original value
//REFERENCE type parameters pass in the address of the original data
//          WARNING any changes to the data at the original address
//                  will be there when you return to the driver program

//the use of the keyword "static" isolates the content of the method
//      to within the method. It DOES NOT allow for global variables
//      It forces the developer to properly scope the variables for 
//      the method.
//using static is an optional choice.
//
//FOR OUR COURSE TO ENSURE APPROPRIATE METHOD DEVELOPMENT, WE WILL USE
//  THE KEYWORD "static" ON OUR METHODS

static int GetIntegerNumber(string prompt)
{
    //any variable declared within this method
    //   "dies" when the method terminates (scope)
    //treat your parameters as if they are local variables
    //   which means they are already declared
    string inputValue = "";
    int localNumber = 0;
    Console.Write(prompt);
    inputValue = Console.ReadLine();
    localNumber = int.Parse(inputValue);


    //the method has stated a return datatype of int
    //this method must return an integer value
    //keyword -> return value;
    return localNumber;
}

static string GetCalculatorOperation()
{
    //any variable declared within this method has no association
    //  with any variable outside of the method
    //variables within a method may have the same name as a variable
    //  outside of the method
    //these variables are independent (restriction due to "static")

    //NOTE: NO VALIDATION IS BEING DONE IN THESE EXAMPLES
    
    string choice = "";
    Console.WriteLine("Calculator Operations");
    Console.WriteLine("a: Addition");
    Console.WriteLine("s: Subtration");
    Console.WriteLine("m: Multiplation");
    Console.WriteLine("d: Division");
    Console.Write("Enter your operator choice:\t");

    choice = Console.ReadLine();
    return choice;
}
static int Addition(int num1, int num2)
{
    //the parameters num1 and num2 are considered declared for 
    //      the method
    //these parameter/variables "live" as long as the method is
    //      executing
    //once the method is finished executing the local parameter/variables
    //      cease to exist, they "die"
    //the parameters in this method are "value-type" parameters
    //therefore they receive a "copy" of the value from the call statement
    //Any alteration of the local copies DO NOT affect the original values
    return num1 + num2;
}

static int Subtraction(int num1, int num2)
{
    return num1 - num2;
}
static int Multiplication(int num1, int num2)
{
    return num1 * num2;
}
static double Division(int num1, int num2)
{
    return (double)num1 / (double)num2;
}