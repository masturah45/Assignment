﻿using System;

namespace num11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            decimal n = int.Parse(Console.ReadLine());
            int zeroes = 0;
            for (int i = (int)(n - 1); i > 0; i--)n *= i;
            Console.WriteLine("N! is {0} and it ends ", n);
            do
            {
              n /= 10;
              zeroes++;  
            } while (n % 10 == 0);
            Console.WriteLine("with{0} zeroes. " , zeroes );

            
                
            
        }
    }
}
