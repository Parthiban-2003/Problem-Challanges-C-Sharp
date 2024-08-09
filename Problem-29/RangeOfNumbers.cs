using System;
using System.Transactions;

namespace Vale
{
    public static class RangeOfNumbers
    {
      public static void Solutions()
        {
            Console.WriteLine("Enter their Number X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Number Y:");
            int nY = Convert.ToInt32(Console.ReadLine());

            for(int i=nX;i<=nY;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}