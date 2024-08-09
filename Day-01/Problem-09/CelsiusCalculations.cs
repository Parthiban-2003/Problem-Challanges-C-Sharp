using System;

namespace Converts
{
    public static class CelsiusCalculations
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their celsius:");
            int nCelsius = Convert.ToInt32(Console.ReadLine());

           int nKelvin = nCelsius + 273;

           int nFahrenheit = (nCelsius * 18 / 10 + 32);

            Console.WriteLine($"Kelvin={nKelvin}");
            Console.WriteLine($"Fahrenheit={nFahrenheit}");

        }
    }
}