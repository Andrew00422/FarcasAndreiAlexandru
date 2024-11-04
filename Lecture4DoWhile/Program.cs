using System;
 namespace exemplu_Do
 {     class DoExample
 {         
static void Main()
 {
   int i = 0;             
   do {
                Console.WriteLine("Valoarea lui i este {0}.", i);
                i+=2;
            }
   while (i <= 100);
            Console.ReadLine();
        }
 }
 }