using System;

namespace Draw
{
    public static class DrawRectagle
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Column:");
            int nColumn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Row:");
            int nRow = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=nRow; i++)
            {
                for(int j=0; j<nColumn; j++)
                {
                    Console.Write(nRow);
                }
                Console.WriteLine();
            }
            
        }
    }
}