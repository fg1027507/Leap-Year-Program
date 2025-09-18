/* Leap Year Calculator
Created on September 18, 2025
Created by Finn Gilbert
Asks the user for a year then finds out if it is a leap year or not
*/
// Ask user for a year and convert it from a string to an integer
Console.WriteLine("Enter a year");
Console.Write(">> ");
int year = Convert.ToInt32(Console.ReadLine());
// Counter to track conditions
int leap = 0;
// Check divisibility by 4
if (year % 4 == 0)
    leap = leap + 1;
// Check divisibility by 100
if (year % 100 == 0)
    leap = leap + 1;
// Check divisibility by 400
if (year % 400 == 0)
    leap = leap + 1;
// Tells the user if the year is a leap year
if (leap == 1 || leap == 3) // divisible by 4 but not 100, OR divisible by 400
    Console.WriteLine($"{year} is a leap year!");
else
    Console.WriteLine($"{year} is not a leap year!");