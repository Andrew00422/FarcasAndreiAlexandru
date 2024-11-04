using System;
namespace ConsoleApplication
{
    class Program
    {
        public static void Main() 
        {
            float a, b;             
string sir;
            Console.Write("The value for the variable a=");             
sir = Console.ReadLine(); a = float.Parse(sir);
            Console.Write("The value for the variable b=");             
sir = Console.ReadLine(); b = float.Parse(sir);
            Console.Write("The sum of a={0} and b={1} is {2}", a, b, a+b);
            Console.ReadLine();
        }
    }
}
