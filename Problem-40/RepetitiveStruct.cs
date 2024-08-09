using System;

namespace truct
{
    public static class RepetitiveStruct
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Value of X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their Value of X:");
            int nY = Convert.ToInt32(Console.ReadLine());

            int i;

            for(i=nX;i<=nY;i++)
            {
                Console.Write($" {i}");
            }
            Console.WriteLine(" ");

             i=nX;

            while(i<=nY)
            {
                Console.Write($" {i}");
                i++;
            }
            Console.WriteLine();

            i = nX;
            do
            {
                Console.Write($" {i}");
                i++;
            } while (i <= nY);
            Console.WriteLine();
        }
    }
}
