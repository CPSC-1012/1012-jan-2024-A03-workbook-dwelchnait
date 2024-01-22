
string myName;
myName = "Conrad";
Console.WriteLine($"hello from {myName}'s World!");

string myAge = "49";
string oneYear = "1";
myAge = myAge + oneYear;

Console.WriteLine($"I am {myAge} years old.");

Console.WriteLine();
Console.WriteLine("*******");
Console.WriteLine("*");
Console.WriteLine("****");
Console.WriteLine("*");
Console.WriteLine("*******");

Console.WriteLine();
Console.WriteLine();
string longLine = "*******";
string shorterLine = "****";
string shortestLine = "*";
Console.WriteLine(longLine);
Console.WriteLine(shortestLine);
Console.WriteLine(shorterLine);
Console.WriteLine(shortestLine);
Console.WriteLine(longLine);

Console.WriteLine();
Console.WriteLine();

string line01 = "*******";
string line02 = "*";
string line03 = "*****";
string line04 = "*";
string line05 = "*******";
Console.WriteLine(line01);
Console.WriteLine(line02);
Console.WriteLine(line03);
Console.WriteLine(line04);
Console.WriteLine(line05);

//myName = "Peter";
//Console.WriteLine($"hello from {myName}'s World!");


//float westCoastPercentage = 43.00f;
//float totalCompanySales = 5300000.00f;
//float westCoastFraction = westCoastPercentage / 100;
//float westCoastSalesUnitSales;

//westCoastSalesUnitSales = westCoastFraction * totalCompanySales;

//Console.WriteLine(westCoastSalesUnitSales);

float westCoastPercentage = 43.00f;
float totalCompanySales = 5300000.00f;
Console.Write("The West Coast Sales Unit will generate: $");
Console.Write(westCoastPercentage / 100 * totalCompanySales);
Console.WriteLine(" in sales.");