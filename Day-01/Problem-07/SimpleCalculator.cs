using System;

namespace Cal
{
    public static class Simplecalculator
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNum1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNum2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{nNum1} + {nNum2} = {nNum1 + nNum2}");
            Console.WriteLine($"{nNum1} - {nNum2} = {nNum1 - nNum2}");
            Console.WriteLine($"{nNum1} * {nNum2} = {nNum1 * nNum2}");
            Console.WriteLine($"{nNum1} / {nNum2} = {nNum1 / nNum2}");
            Console.WriteLine($"{nNum1} % {nNum2} = {nNum1 % nNum2}");
        }
    }
}