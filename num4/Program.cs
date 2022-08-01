using System;

namespace num4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your number");
            int card = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your number");
            int club = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    switch (card)
                    {

                        case 1:
                            Console.WriteLine("club");
                            break;

                        case 2:
                            Console.WriteLine("diamond");
                            break;

                        case 3:
                            Console.WriteLine("heart");
                            break;

                        case 4:
                            Console.WriteLine("spade");
                            break;
                    }

                    switch (club)
                    {

                        case 1:
                            Console.WriteLine("3");
                            break;

                        case 2:
                            Console.WriteLine("4");
                            break;

                        case 3:
                            Console.WriteLine("5");
                            break;

                        case 4:
                            Console.WriteLine("6");
                            break;

                        case 5:
                            Console.WriteLine("7");
                            break;

                        case 6:
                            Console.WriteLine("8");
                            break;

                        case 7:
                            Console.WriteLine("9");
                            break;

                        case 8:
                            Console.WriteLine("10");
                            break;
                        case 9:
                            Console.WriteLine("J");
                            break;
                        case 10:
                            Console.WriteLine("Q");
                            break;
                        case 11:
                            Console.WriteLine("K");
                            break;
                        case 12:
                            Console.WriteLine("A");
                            break;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
