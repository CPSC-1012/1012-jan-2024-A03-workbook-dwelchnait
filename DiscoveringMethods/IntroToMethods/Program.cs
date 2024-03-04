// See https://aka.ms/new-console-template for more information
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

//method call statement
//this method is commonly referred to as a function
//a fuction method is identified by the fact that a value is returned
//  from the method
//the returned value can be saved to a local variable (num1)
//the method is referred to on the call by the method name (GetIntegerNumber)
//this method is receiving a value (argument) via the call
num1 = GetIntegerNumber("Enter you first calucation number:"); 
num2 = GetIntegerNumber("Enter you second calucation number:");
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

int GetIntegerNumber(string prompt)
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