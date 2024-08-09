using System;

namespace Divmod
{
    public static class DivisionModulo

    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            int nDivision = nNum1 / nNum2;

            int nModulo = nNum1 % nNum2;


            Console.WriteLine(nDivision);
            Console.WriteLine(nModulo);

        }
    }
}