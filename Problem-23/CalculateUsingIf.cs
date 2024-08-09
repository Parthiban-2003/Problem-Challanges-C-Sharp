using System;

namespace Calc
{
    public static class CalculateUsingIf
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Operation:");
            char cOperations = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNumber2=Convert.ToInt32(Console.ReadLine());

            if(cOperations == '+')
            {
                int nResult = nNumber1 + nNumber2;
                Console.WriteLine($"{nNumber1}+{nNumber2}={nResult}");
            }
            else if(cOperations=='-')
            {
                int nResult = nNumber1 - nNumber2;
                Console.WriteLine($"{ nNumber1}-{ nNumber2}= {nResult}");
            }
            else if(cOperations == '*')
            {
                int nResult = nNumber1 * nNumber2;
                Console.WriteLine($"{nNumber1}*{nNumber2}={nResult}");
            }
            else
            {
                int nResult = nNumber1 / nNumber2;
                Console.WriteLine($"{nNumber1}/{nNumber2}={nResult}");
            }
        }
    }
}