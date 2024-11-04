using System;
 namespace exemplu_While
 {
     class WhileExample
 {   static void Main()
 {
   int i = 0;
   while (i <= 100)
            {
                Console.WriteLine("The value of i is {0}.", i);
                i+=2;
            }
            Console.ReadLine();
        }
    }
}