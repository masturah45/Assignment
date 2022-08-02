using System;

namespace num10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N : (N < 20) ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)Console.WriteLine("{0}", j);
                Console.WriteLine();
            }
        }
    }
}
