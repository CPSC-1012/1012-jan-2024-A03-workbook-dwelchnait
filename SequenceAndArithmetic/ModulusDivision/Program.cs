// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Modulus Divsion!\n");

//This program will receive a random number between 1 and 1000, separate the
//  digits of the number and sum those digits together.

//Plan (this is the WHAT's to do)
//DECLARE rnd as Random
//DELCARE rndNum as integer
//DECLARE digitSum as Integer
//DECLARE hundreds as Integer
//DECLARE tens as Integer
//DECLARE units as Integer

//SET rnd to an instance of Random
//SET rndNum to a value generate by rnd (1-1000)
//OBTAIN the hundreds digit from rndNum
//OBTAIN the tens digit from rndNum
//OBTAIN the units digit form rndnum
//SET digitSum to the sum of the digits (hundreds + tens + units)

//DISPLAY the random number and sum of its digits

Random rnd;
int rndNum, digitSum, hundreds, tens, units, tempDigits;

//since, i want my own instance of a class i MUST request an instance be create
rnd = new Random();

// the .Next method of Random take a range set by an low value which is included
//      and an upper value of your range which is NOT include
rndNum = rnd.Next(1, 1000);

hundreds = rndNum / 100;
tempDigits = rndNum % 100;
tens = tempDigits / 10;
tempDigits = tempDigits % 10;  //b = c
units = tempDigits;            //a = b 

//units = tempDigits % 10;   //a = c

digitSum = hundreds + tens + units;

Console.WriteLine($"\nThe sum of digits for {rndNum} is {digitSum}");


