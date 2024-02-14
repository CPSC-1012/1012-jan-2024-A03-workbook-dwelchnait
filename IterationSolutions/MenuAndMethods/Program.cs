﻿// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;
//
//start of the main driver code
//
Console.WriteLine("\nUsing Various loop structures\n");

//an example of using a menu to determine which example to execute
//post-test loop
string menuChoice = "";

//a menu displays to the user a number of selection to choose from
//the user makes a selection and the program executes the selection
//since the user must make at least on choice, the logic will
//  be executed at least once
//this is an opportunity for using the post-test loop
do
{
    // display the menu choices
    Console.WriteLine("\nA: Pre-Test Loop sample");
    Console.WriteLine("B: Post-Test Loop sample");
    Console.WriteLine("C: Pre-Test Counter Loop sample");
    Console.WriteLine("D: Search string for character");
    Console.WriteLine("X: Exit");
    Console.Write("Enter your choice:\t");
    menuChoice = Console.ReadLine();
    //menuchoice needs to be tested against a single value
    //  in an equals relationship to determine what to execute
    //this lis an opportunity to use the case descision structure
    switch(menuChoice.ToUpper())
    {
        case "A":
            {
                //call the method to execute by stating its name
                SimplePreTestLoop();
                break;
            }
        case "B":
            {
                //call the method to execute by stating its name
                SimplePostTestLoop();
                break;
            }
        case "C":
            {
                Console.WriteLine("\n\nyou choice item C\n");
                break;
            }
        case "D":
            {
                Console.WriteLine("\n\nyou choice item B\n");
                break;
            }
        case "X":
            {
                Console.WriteLine("\n\nyou choice item X\n");
                break;
            }
        default:
            {
                Console.WriteLine($"\n\nyour choice of {menuChoice} is invalid. Try again\n");
                break;
            }
    }
} while (!(menuChoice.ToUpper().Equals("X")));

//
//end of the main driver code and your program
//

//Methods

//a method is a coding block that can be code in isolation from
//  the rest of your program BUT remains part of the program
//to execute the method, you call the method by name
//the method will execute from the start of the method to the
//  end of the method
//after execution, program control returns to where the method
//  was called

void SimplePreTestLoop()
{
    //read in numbers while the number is not 0
    int num = 0;
    string inputValue = "";
    Console.Write("\tEnter a number, use 0 to terminate;\t");
    inputValue = Console.ReadLine();
    num = int.Parse(inputValue);

    //loop
    //pre-test is to ask the loop condition question BEFORE entering
    while (num != 0)
    {
        Console.WriteLine($"You entered the number:\t {num}");

        //repeat the code to get the next number
        Console.Write("\tEnter a number, use 0 to terminate;\t");
        inputValue = Console.ReadLine();
        num = int.Parse(inputValue);
    }
}

void SimplePostTestLoop()
{
    //read in numbers while the number is not 0
    int num = 0;
    string inputValue = "";


    //loop
    //post-test is to ask the loop condition question AFTER executing
    //  the loop code at least once
    do
    {
        Console.Write("\tEnter a number, use 0 to terminate;\t");
        inputValue = Console.ReadLine();
        num = int.Parse(inputValue);

        //IF you do NOT wish the processing logic to execute
        //you WILL need to test for the termination condition

        if (num != 0)
        {
            Console.WriteLine($"You entered the number:\t {num}");
        }


    } while (num != 0);
}
