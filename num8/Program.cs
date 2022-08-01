using System;

namespace num8
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter N :(N >= 0");
             int n = int.Parse(Console.ReadLine());
             int factN = 2 * n;
             int factplus = n + 1;
             for (int i = factN - 1; i > 0; i--)factN *= i;
             for (int i = factplus - 1; i > 0; i--)factplus *= i;
             for (int i = n - 1; i > 0; i--)n *= i;
             
             Console.WriteLine("Result is {0} ", factN / (factplus * n));
                 
             
             
                 
             
             
                 
             
             
             
        
             
             
             
             
             
        }
    }
}
