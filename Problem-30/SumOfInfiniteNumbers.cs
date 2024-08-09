using System;

namespace Finite
{
    public static class SumOfInfiniteNumbers
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            do
            {
                nX = Convert.ToInt32(Console.ReadLine());
                sum = sum + nX;

                if (nX != 0)
                {
                    Console.WriteLine(sum);
                }
            } while (nX != 0);

            Console.WriteLine("FINISHED");
        }
    }
}