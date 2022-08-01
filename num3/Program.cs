using System;

namespace num3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your length");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];
            int lowest = 0;
            int largest = 0;
            int num = 0;
            for (int i = 0; i <myArray.Length; i++)
            {
                Console.WriteLine("enter your number");
                num = int.Parse(Console.ReadLine());
                if(i == 0) lowest = largest = num;
                else
                {
                    if(lowest > num) lowest = num;
                    if(largest < num) largest = num;
                }

               
                
            }
            Console.WriteLine("lowest - {0} , largest - {1}" , lowest , largest);
            
        }
    }
}
