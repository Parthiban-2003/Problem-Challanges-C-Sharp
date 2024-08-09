using System;

namespace Zero
{
    public class DivisionByZero
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their first Number:");
            int nX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their second Number:");
            int nY = Convert.ToInt32(Console.ReadLine());

            try
            {
                Console.WriteLine("{0}/{1}= {2}", nX, nY, nX/nY );
            }
            catch 
            {
                Console.WriteLine("Cannot divide by 0");
            }
        }
    }
}