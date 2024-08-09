
﻿using System;

namespace Sums
{
    public class SumsSquare
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first value:");
            int nNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{nNum}*{nNum}={nNum * nNum}");
        }
    }
}
