
using System;

namespace multys
{
    public static class InfiniteMultiplicationTables
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Value1:");
            int nValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their value2:");
            int nValue2 = Convert.ToInt32(Console.ReadLine());

            for(int i=nValue1;i<=nValue2;i++)
            {
                for(int j=1;j<=10;j++)

                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
    }
}