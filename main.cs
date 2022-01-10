using System;
 
namespace Sample
{
  class Test
    {
      public static void Main(string[] args)
       {
         bool m = true;
         int number;
         Console.Write("Enter a number - ");
         
         number = Convert.ToInt32(Console.ReadLine());
         if(number <= 0)
    {
      Console.WriteLine("Invalid number");
      return;
    }
         for (int d = 2; (d - 1) <= number; d = d * 2)
         {
       if (((Math.Abs(number - d)) == 1) || ((number + d) == 1))
       {
         Console.WriteLine("it is a Mersenne prime number");
         return;
       }
     }
     for (int a = 2; a <= number / 2; a++)
    {
        if (number % a == 0 && a > 0)
        {
            m = false;
            Console.WriteLine(" it is not a prime number");
            return;
        }
      
    }
    
      Console.WriteLine("it is a regular prime number");
      return;
    }
         
    }
}
