// See https://aka.ms/new-console-template for more information
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
if (taxable == false)
{
    tax = (quantity * price) * gst;
}
Console.WriteLine($"The tax on my {quantity} items each priced at " +
    $" ${price.ToString("0.00")} with a tax rate of {gst} is " +
    $" ${tax.ToString("0.00")}");





