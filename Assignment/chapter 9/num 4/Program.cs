using System;

namespace num4
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber(5);
            
        }
        public static void PrintNumber(int num1)
        {
            
            int[] array = {1,2,4,4,5,5,5};
            int count = 0;

            for (int i = 0; i <array.Length; i++)
            {
               if (num1 == array[i])
               {
                   count ++;
               } 
               
            }
            Console.WriteLine(count);
        }
        
        
            
        
    }
}
