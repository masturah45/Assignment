using System;

namespace num1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
