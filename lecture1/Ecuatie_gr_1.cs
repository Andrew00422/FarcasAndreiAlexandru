using System;
namespace Lecture1
{
    class Ecuatie_gr_1
    {
        public static void Run()
        {
                 float a, b, x;

            Console.Write("Introduceti a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Introduceti b = ");
            b = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("Ecuatie nedeterminata.");
                else
                    Console.WriteLine("Ecuatie imposibila.");
            }
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x = {0}", x);
            }

            Console.ReadKey();

        }
    }
}