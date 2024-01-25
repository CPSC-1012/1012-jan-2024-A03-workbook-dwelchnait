// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Hexagon Calculator\n");

//This program will input a side length value for a hexagon then calculate
//      and display the hexagon area.

//Plan
//DECLARE inputValue as string
//DELCARE side as double
//DECLARE area as double

//Prompt for side
//Read input
//SET side to input


//Calculate and set area to ((3 * sqrt(3)) / 2) * side *side


//DISPLAY area in a statement

string inputValue = "";
double side = 0.0;
double area = 0.0;

Console.Write("\nEnter the hexagon side length:\t");
inputValue = Console.ReadLine(); //data comes in as a string
side = Convert.ToDouble(inputValue); //another way of coverting data

area = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(side, 2);

Console.WriteLine($"The area of the hexagon with a side of {side} is {area.ToString("#,##0.0000")}");
