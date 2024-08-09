using System;

namespace Posnag
{
    public static class PositiveNagative
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number:");
            int nX=Convert.ToInt32(Console.ReadLine());

            if(nX>0)
            {
                Console.WriteLine("The Given Number is Postive.");
            }
            else
            {
                Console.WriteLine("The Given Number is Negative.");
            }
        }
    }
}