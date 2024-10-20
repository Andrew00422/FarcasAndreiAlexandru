using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to the C# Console Application!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Data Types Display");
                Console.WriteLine("2. Basic Math Operations");
                Console.WriteLine("3. Conditional Statements");
                Console.WriteLine("4. Loop Demonstrations");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        DataType.Display();
                        break;
                    case "2":
                        MathOperations.Perform();
                        break;
                    case "3":
                        ConditionalStatements.CheckNumber();
                        break;
                    case "4":
                        LoopDemonstrations.DemonstrateLoops();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the application! Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
            }
        }
    }
}