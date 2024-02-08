// See https://aka.ms/new-console-template for more information
Console.WriteLine("Using the Conditional operator");

//the conditional operator is a way to code a decision without
//  use an if else structure
// used to generate a single value response to a decision
//unlike a if else structure that can have a coding block
//      as the true or flase path; the conditional operator
//      allows for only a single value
//the conditional operator can be used in various locations

//syntax:  (condition(s)) ? true value : false value

//         (conditions(s)) if true value else false value
//          if (condition(s)) {true value} else {false value}
string nightday = "D";
string lightsOn = (nightday.Equals("D")) ? "No" : "Yes";

//if (nightday.Equals("D"))
//{
//    lightsOn = "No";
//}
//else
//{
//    lightsOn = "Yes";
//}
int grade = 70;
char gradeLetter = (grade > 80) ? 'A' : (grade > 70) ? 'B' :
                                        (grade > 60) ? 'C' :
                                        (grade > 50) ? 'D' : 'F';
Console.WriteLine($"lights are on? {lightsOn}. " +
    $" Your grade of {grade} is an {gradeLetter} ");