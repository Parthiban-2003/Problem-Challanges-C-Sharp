using System;

namespace Priorty
{
    public static class OrderOfPriorty

    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their number:");
            int nNum = int.Parse(Console.ReadLine());

            int nVal1 = (-6 + nNum * 5);
            int nVal2 = ((13 - 2) * nNum);
            int nVal3 = ((nNum + -2) * (20 / 10));
            int nVal4 = ((12 + nNum) / (5 - 4));


            Console.WriteLine(nVal1);
            Console.WriteLine(nVal2);
            Console.WriteLine(nVal3);
            Console.WriteLine(nVal4);

        }
    }
}