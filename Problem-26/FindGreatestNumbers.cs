using System;

namespace numm
{
    public static class FindGreatestNumbers
    {
        public static void Solutions()
        
        {
            Console.WriteLine("Enter their first number:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second number:");
            int nY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their third number:");
            int nZ = Convert.ToInt32(Console.ReadLine());

            if (nX > nY && nX > nZ)
            {
                Console.WriteLine(nX);
            }
            else if (nY > nX && nY > nZ)
            {
                Console.WriteLine(nY);
            }
            else if (nZ > nX && nZ > nY)
            {
                Console.WriteLine(nZ);
            }
            else
            {
                Console.WriteLine(nX);
            }

            //int nGreastestnumber = nX;
            //if(nY>nGreastestnumber)
            //{
            //    nGreastestnumber = nY;
            //}
            //else if(nZ>nGreastestnumber)
            //{
            //    nGreastestnumber = nZ;
            //}
            //Console.WriteLine($"The Greatest Value is: { nGreastestnumber}");
        }
    }
}