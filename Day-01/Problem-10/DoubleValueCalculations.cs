﻿using System;

namespace values
{
    public static class DoubleValueCalculations
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their length:");
            double dLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter their breath:");
            double dBreath = Convert.ToDouble(Console.ReadLine());

            double dPerimeter = (2 * (dLength + dBreath));
            double dArea = dLength * dBreath;
            double dDiagonal = Math.Sqrt(dLength * dLength + dBreath * dBreath);

            Console.WriteLine(dPerimeter);
            Console.WriteLine(dArea);
            Console.WriteLine(dDiagonal);

        }
    }
}
