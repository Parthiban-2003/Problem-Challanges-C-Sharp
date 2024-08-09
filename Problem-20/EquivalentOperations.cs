using System;

namespace Equivalent
{
    public static class EquivalentOperations

    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their third number:");
            int nNum3 = Convert.ToInt32(Console.ReadLine());

            int nLHS = (nNum1 + nNum2) * nNum3;
            int nRHS = ((nNum1 * nNum3) + (nNum2 * nNum3));

            Console.WriteLine($"Left hand side:{nLHS}");
            Console.WriteLine($"Right hand side:{nRHS}");

        }
    }
}