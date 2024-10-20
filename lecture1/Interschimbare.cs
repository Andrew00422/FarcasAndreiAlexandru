using System;
namespace Lecture1
{
    class Interschimbare
    {
        public static void Run()
        {
                  int a, b, aux; 
            Console.Write("Introduceti primul numar a = "); 
            a = int.Parse(Console.ReadLine()); 
            Console.Write("Introduceti al doilea numar b = "); 
            b = int.Parse(Console.ReadLine()); 
            Console.WriteLine("a={0}, b={1}", a, b); 
            aux = a; a = b; b = aux; 
            Console.Write("Dupa interschimbare a={0}, b={1}", a, b); 
            Console.ReadKey();
      
        }
    }
}