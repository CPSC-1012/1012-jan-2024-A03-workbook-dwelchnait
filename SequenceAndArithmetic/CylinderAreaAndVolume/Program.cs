// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, Cylinder Calculator\n");
//This program will input a radius and length value for a cylinder then calculate
//      and display the clyinder area and volume.

//Plan
//DECLARE inputValue as string
//DELCARE radius as double
//DELCARE length as double
//DECLARE pi as double
//DECLARE area as double
//DECLARE volume as double

//Prompt for radius
//Read input
//SET radius to input
//Prompt for length
//Read input
//SET length to input
//SET pi to the Math constant of pi

//Calculate and set area to radius * radius * pi
//Calculate and set volume to area * length

//DISPLAY area in a statement
//DISPLAY volume in a statement

string inputValue;
double radius = 0.0;
double length = 0.0;
double pi = 0.0;
double area = 0.0, volume = 0.0;

Console.Write("Enter your radius:\t");
inputValue = Console.ReadLine();
//convert the strng to the appropriate datatype
radius = double.Parse(inputValue);

Console.Write("Enter your length:\t");
inputValue = Console.ReadLine();
//convert the strng to the appropriate datatype
length = double.Parse(inputValue);

//introduce you to the Math class
//the syntax for using items from the Math class is -> Math.classitem
pi = Math.PI;

//area = radius * radius * pi;
area = Math.Pow(radius, 2) * pi;
volume = area * length;

Console.WriteLine($"The area is {area.ToString("#,##0.0000")}"); //auto rounds up
Console.WriteLine($"The area is {Math.Round(area,4,MidpointRounding.ToNegativeInfinity)}"); //Math class .Round
Console.WriteLine($"The volume is {volume.ToString("#,##0.0")}");