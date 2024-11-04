using System; namespace exemplu_for
{
  class ExempluFor
    {
      static void Main()
        {
          for (int i = 1; i <= 100; i++)
           Console.WriteLine("The value of i is: {0}.", i);
           Console.ReadLine();
           i++; // error !!!
        }
    }
}
