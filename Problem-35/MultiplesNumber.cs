using System;

namespace Pro
{
    public static class MultiplesNumber
    {
        public static void Solutions()
        {
            for(int i=0;i<=500;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
