using System;

namespace num12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number");
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n , 2);
            Console.WriteLine("Result is {0}" , binary);
        }
    }
}
