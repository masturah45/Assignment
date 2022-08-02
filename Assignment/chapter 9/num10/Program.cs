using System;

namespace num10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}! = {1}" , i,Factorial(i));
            }
            
        }
        static double Factorial(double number)
        {
            if(number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
            Console.WriteLine();
        }
    }
}
