using System;

namespace num16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int temp = 0;
            int randomNumber = 0;
            Console.WriteLine("enter your number");
            int a = int.Parse(Console.ReadLine());
            int [] myArray = new int [a];
            for (int i = 0; i <myArray. Length; i++)
            {
                myArray[i] = i;
            }
            foreach (int i in myArray)
            {
                randomNumber = num.Next(0 , a);
                temp = myArray[i];
                myArray[i] = myArray[randomNumber];
                myArray[randomNumber] = temp;
            }
            foreach (int i in myArray) Console.WriteLine(myArray[i]);
            
                
            
        }
    }
}
