using System;

namespace num13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("binary");
            string b = (Console.ReadLine());
            int dec = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if(b[b.Length- i -1] == '0')continue;
                dec += (int) Math.Pow(2,i);
            }
            Console.WriteLine(dec);
        }
    }
}
