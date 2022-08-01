using System;

namespace num7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: (1 < K < N) ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K : (1 < K < N) ");
            int k = int.Parse(Console.ReadLine());
            int nk = n - k;
            for (int i = n - 1; i > 0; i--)n *= i;
            for (int i = k - 1; i > 0; i--)k *= i;
            for (int i = nk - 1; i > 0; i--)nk *= i;
            Console.WriteLine("Result is {0}" , n * k / nk);

            
                
            
        }
    }
}
