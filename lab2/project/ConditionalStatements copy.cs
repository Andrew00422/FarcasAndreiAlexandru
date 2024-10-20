// ConditionalStatements.csx
// Exercise: Write a function that checks whether a given number is positive, negative, or zero, and displays the appropriate message.
// Answer:
using System;

void CheckNumber(int number)
{
    // Check if the number is greater than zero
    if (number > 0)
    {
        Console.WriteLine($"{number} is positive.");
    }
    // Check if the number is less than zero
    else if (number < 0)
    {
        Console.WriteLine($"{number} is negative.");
    }
    // If the number is zero
    else
    {
        Console.WriteLine("The number is zero.");
    }
}

// Test the function with different numbers
CheckNumber(10);   // Should display "10 is positive."
CheckNumber(-5);   // Should display "-5 is negative."
CheckNumber(0);    // Should display "The number is zero."
