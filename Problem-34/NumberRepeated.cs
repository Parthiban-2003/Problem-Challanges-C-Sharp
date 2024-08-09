using System;

namespace repeats
{
    public static class NumberRepeated
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Number Y:");
            int nY = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<nY;i++)
            {
                Console.WriteLine(nX);
            }
        }
    }
}
