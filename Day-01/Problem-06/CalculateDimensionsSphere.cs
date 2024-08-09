using System;

namespace Calculate
{
    public static class CalculateDimensionsSphere
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their radius");
            int nRadius =Convert.ToInt32(Console.ReadLine());

            double nPi = 3.14;

            double surface = 4 * nPi * (nRadius * nRadius );
            double volume = (4 / 3) * nPi * (nRadius * nRadius * nRadius);

            Console.WriteLine(surface);
            Console.WriteLine(volume);
        }
    }
}
