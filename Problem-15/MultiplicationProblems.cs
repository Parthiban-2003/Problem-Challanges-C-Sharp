using System;

namespace Multy
{
    public static class MultiplicationProblems

    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their third number:");
            int nNum3 = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(nNum1 * nNum2 * nNum3);

        }
    }
}