using System;

namespace Question_2
{
    class Program
    {
        static void GetCombinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                    if (i < arr.Length - 1) Console.Write("{0} ", arr[i]);
                    else Console.Write(arr[i]);
                Console.Write("), ");
            }
            else
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GetCombinations(arr, index + 1, i, end);
                }
        }
        static void Main(string[] args)
        {
           Console.Write("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            GetCombinations(arr, 0, 1, n); 
        }
    }
}
