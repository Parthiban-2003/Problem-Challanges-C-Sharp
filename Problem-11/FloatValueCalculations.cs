using System;

namespace Fvalues
{
    public static class FloatValuesCalculations
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their distance:");
            float fDistance = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter their hour:");
            float fHour = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter their mins:");
            float fMintues = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter their seconds:");
            float fSeconds = Convert.ToSingle(Console.ReadLine());


            float fSecond = (fHour * 3600) + (fMintues * 60) + fSeconds;
            float fMps = fDistance / fSecond;
            float fKph = fDistance / 1000.0f / fSecond / 3600.0f;
            float fMph = fKph / 1.609f;

            Console.WriteLine("Speed in meters/sec is {0}", fMps);
            Console.WriteLine("Speed in km/h is {0}", fKph);
            Console.WriteLine("Speed in miles/h is {0}", fMph);

        }
    }
}