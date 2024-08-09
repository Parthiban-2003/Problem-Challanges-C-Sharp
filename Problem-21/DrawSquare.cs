using System;

namespace Square
{
    public static class DrawSquare
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their number X:");
            int nNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their width");
            int nWidth = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nWidth; i++)
            {
                for (int j = 0; j < nWidth; j++)
                {
                    Console.Write(nNum);
                }
                Console.WriteLine();
            }


        }
    }
}