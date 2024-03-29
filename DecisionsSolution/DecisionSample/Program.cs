﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("\n\tDecisions Decisions Decisions\n");
/*
 * Decisions control the flow of your critical paths through your
 * program logic.
 * 
 * Most programing languages use the keyword > if < to specify
 *  your question for control program flow
 *  
 *  syntax:
 *  
 *  if (condition(s))
 *  [{]
 *      true path coding block
 *  [}]
 *  [else
 *  [{]
 *      false path coding block
 *  [}]]
 *  
 *  rules:
 *  if your coding block contains more than one statement, you MUST enclose
 *      the code within {...}
 *  You do not need to have an > else < on your if structure -- one-way
 *  If you have both a true set of logic and a false set of logic
 *      you will need the > else < structure -- two-way
 *  You may nest decision structures within decision structures -- nested-ifs
 *  You may discover that your logic creates unique structures
 *      when created:  Branch-Structure -- with this structure you can
 *      use a modified if/else called the if-else structure
 *  The final discision structure is called a case structure and can be
 *      coded using the Branch-Structure or the switch case statement
 */

// One-way if
// this has no false path logic

int quantity = 5;
bool taxable = true;
double gst = 0.05;
double tax = 0.0;
double price = 2.75;

// calculate the tax on your purchase if the item is taxable
if (taxable == true)
{
    tax = (quantity * price) * gst;
}
Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("0.00")} with a tax rate of {gst} is " +
    $" ${tax.ToString("0.00")}");

/*What is the condition?
 *
 * taxable == false
 * 
 * structure  argument operator value
 * the argument and value can both be variables
 * the operator can take on many forms
 *  our operator is a relative operator
 *  relative operators are ==, <, <=, >, >=
 * the condition is resolved to either a boolean true or false for
 *  exection
 * the argument and/or value maybe an expression
 *   example argument =>  (a + b) >= c
 *                       sum(a,b) >= c
 *                          true/false
 *                          
 *  Question: we have in the example a boolean compared to a boolean
 *            this resolves to a boolean value
 *  Do I need to have the condition structure of boolean == boolean?
 *  this is an example where you could reduce your if condition
 *      to just the argument  (SPECIAL CONDITION)
 *  
 *  our if structure could have been written as:  if(taxable)
 *
*/

//two-way decision

if (taxable)
{
    tax = (quantity * price) * gst;
    Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("0.00")} with a tax rate of {gst} is " +
    $" ${tax.ToString("0.00")}");
}
else
{
    Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("0.00")} is $0.00 because the items are not taxable.");
}

//Decision Exercise 1 Question 1

string inputValue;
int guess = 0;
Random rnd = new Random();
int flip = rnd.Next(0, 2);
Console.Write("Enter 1 for Heads or 0 for Tails:\t");
inputValue = Console.ReadLine();
guess = int.Parse(inputValue);

if (guess == flip)
{
    Console.WriteLine($"Your guess of {guess} match the flip of {flip} .");
}
else
{
    Console.WriteLine($"Your guess of {guess} does not match the flip of {flip} .");
}


