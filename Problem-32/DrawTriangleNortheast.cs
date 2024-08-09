using System;

namespace Filterss
{
    public static class DrawTriangleNortheast
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their number X:");
            int nX = Convert.ToInt32(Console.ReadLine());


            for(int i=1;i<nX;i++)
            {
                for(int j=1;j<i;j++)
                {
                    Console.Write(" ");
                }
                for(int k=i;k<=nX;k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}