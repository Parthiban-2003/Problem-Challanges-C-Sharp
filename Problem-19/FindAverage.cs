
﻿using System;

namespace Avg
{
    public static class FindAverage

    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first number:");
            int nNum1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nNum2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their third number:");
            int nNum3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their fourth number:");
            int nNum4 = Convert.ToInt32(Console.ReadLine());


            int nAverage = ((nNum1 + nNum2 + nNum3 + nNum4) / 4);

            Console.WriteLine(nAverage);

        }
    }
}
