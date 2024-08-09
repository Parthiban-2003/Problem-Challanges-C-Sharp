using System;

namespace Fvalues
{
    public static class DrawTriangle
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their number X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Width:");
            int nY = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<nY;i++)
            {
                for(int j=0;j<nY-i;j++)
                {
                    Console.Write(nX);
                }
                Console.WriteLine();
            }

        }
    }
}