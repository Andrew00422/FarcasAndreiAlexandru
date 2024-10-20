using System;

namespace ConsoleApp
{
    public static class MathOperations
    {
        public static void Perform()
        {
            Console.Write("Enter first number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {x + y}");
            Console.WriteLine($"Subtraction: {x - y}");
            Console.WriteLine($"Multiplication: {x * y}");
            Console.WriteLine($"Division: {x / y}");
            Console.WriteLine($"Modulus: {y} % {x} = {x % y}");
        }
    }
}