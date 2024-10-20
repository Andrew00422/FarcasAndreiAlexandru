// Loops.csx
// Exercise: Write a function that uses a for loop, a while loop, and a do-while loop to display numbers from 1 to 5.
// Answer:
using System;

void DisplayNumbersUsingLoops()
{
    // Using a for loop to display numbers from 1 to 5
    Console.WriteLine("Using a for loop:");
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(i);
    }

    // Using a while loop to display numbers from 1 to 5
    Console.WriteLine("\nUsing a while loop:");
    int j = 1;
    while (j <= 5)
    {
        Console.WriteLine(j);
        j++;
    }

    // Using a do-while loop to display numbers from 1 to 5
    Console.WriteLine("\nUsing a do-while loop:");
    int k = 1;
    do
    {
        Console.WriteLine(k);
        k++;
    } while (k <= 5);
}

// Call the function to display numbers using loops
DisplayNumbersUsingLoops();
