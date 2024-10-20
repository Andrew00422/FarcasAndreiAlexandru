// DataTypes.csx
// Exercise: Declare and initialize variables of different data types, and display their values.
// Answer:
using System;

void DisplayDataTypes()
{
    // Declare and initialize an integer variable
    int integerValue = 42;
    
    // Declare and initialize a double variable
    double doubleValue = 3.14159;
    
    // Declare and initialize a decimal variable
    decimal decimalValue = 19.99m;
    
    // Declare and initialize a char variable
    char characterValue = 'A';
    
    // Declare and initialize a string variable
    string stringValue = "Hello, World!";
    
    // Declare and initialize a boolean variable
    bool booleanValue = true;

    // Display the values of all variables
    Console.WriteLine($"Integer: {integerValue}");
    Console.WriteLine($"Double: {doubleValue}");
    Console.WriteLine($"Decimal: {decimalValue}");
    Console.WriteLine($"Character: {characterValue}");
    Console.WriteLine($"String: {stringValue}");
    Console.WriteLine($"Boolean: {booleanValue}");
}

// Call the function to display data types
DisplayDataTypes();
