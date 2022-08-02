using System;

namespace num6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your length");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter {0} number ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            compareNumber(array);
            if (number == int.MinValue) Console.WriteLine("-1");
            else Console.WriteLine("{0} is larger than its neighbours ", number);




        }



        static int number = int.MinValue;
        static void compareNumber(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i - 1]) ;
                {
                    number = array[i];
                    break;
                }
            }
        }
    }
}

