using System;

namespace num2
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Console.WriteLine("enter the 1st number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the 2nd number");
        int num2 = int.Parse(Console.ReadLine());
        GetMax(num1 , num2);
        
        }


         public static void GetMax(int num1 , int num2)
         {
                
        if (num1 > num2)
        {
            Console.WriteLine($"the largest of the two numbers is:  {num1}  ");
        }
        else if(num2 > num1 )
        {
            Console.WriteLine($"the largest of the two numbers is: {num2} "); 
        }
        else
        {
            Console.WriteLine("the numbers are equal");
        }
        } 

        public static void GetMax1(int num1,int num2)
        {
            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
          Console.WriteLine("enter the second number");
            int second = int.Parse(Console.ReadLine()); 
              Console.WriteLine("enter the third number");
            int third = int.Parse(Console.ReadLine()); 
        }




    } 

        
         
     
        
   
    











}
        
         
        



        







    


