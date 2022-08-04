using System;

namespace num9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1;
            int temp = 1;
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               temp *= i/Math.Pow(x , i);
               sum += temp;
            }
            Console.WriteLine("Result is {0}", sum);
        }
    }
}
