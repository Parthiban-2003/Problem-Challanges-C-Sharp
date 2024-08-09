using System;

namespace insst
{
    public static class UsingInstructiondoWhile
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number:");
            int nX = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(nX * 10);

                Console.WriteLine("Enter their Number:");
                nX=Convert.ToInt32(Console.ReadLine());

            } while (nX != 0);
        }
    }
}