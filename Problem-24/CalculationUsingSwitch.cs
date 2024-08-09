using System;
using System.ComponentModel;

namespace Switchh
{
    public static class CalculationUsingSwitch
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Operations:");
            char cOperations=Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNumber2=Convert.ToInt32(Console.ReadLine());

            switch(cOperations)
            {
                case '+':
                    int nResult = nNumber1 + nNumber2;
                    Console.WriteLine($"{nNumber1}+{nNumber2}={nResult}");
                    break;

                case '-':
                    int nResults = nNumber1 - nNumber2;
                    Console.WriteLine($"{nNumber1}-{nNumber2}= {nResults}");
                    break;

                case '*':
                    int nRes = nNumber1 * nNumber2;
                    Console.WriteLine($"{nNumber1}*{nNumber2}= {nRes}");
                    break;

                case '/':
                    int nRest = nNumber1 / nNumber2;
                    Console.WriteLine($"{nNumber1}/{nNumber2}= {nRest}");
                    break;

                default:
                    Console.WriteLine("MisMatched");
                    break;

            }
        }
    }
}