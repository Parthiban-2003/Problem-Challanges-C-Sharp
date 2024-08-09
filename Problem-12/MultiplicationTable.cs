using System;

namespace Table
{
    public static class MultiplicationTable
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number:");
            int nNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{nNum}*{i}={nNum * i}");
            }

        }
    }
}