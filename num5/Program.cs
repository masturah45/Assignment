using System;

namespace num5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int number = int.Parse(Console.ReadLine());
            int j = 0;
            int q = 1;
            int l = 0;
            int sum = 0;
            int final = 0;
            Console.WriteLine($"{j}");
            Console.WriteLine($"{q}");
            for (int i = 1; i <= number; i++)
            {
               l = j + q;
               Console.WriteLine(l);
               j = q;
               q = l;
               sum += q; 
               final = sum + 1;
            }
            Console.WriteLine($"the sum is {final}");
        }
    }
}
