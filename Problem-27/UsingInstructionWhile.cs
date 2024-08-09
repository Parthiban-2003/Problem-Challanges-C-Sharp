using System;

namespace inst
{
    public static class UsingInstructionWhile
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number:");
            int nX = Convert.ToInt32(Console.ReadLine());

            //while(nX != 0)
            //{
            //    Console.WriteLine(nX * 10);

            //    Console.WriteLine("Enter their Number:");
            //    nX = Convert.ToInt32(Console.ReadLine());
            //}

            while (true)
            {
                Console.WriteLine(nX * 10);
                Console.WriteLine("Enter their Number:");
                nX = int.Parse(Console.ReadLine());

                if (nX == 0)
                {
                    break;
                }
            }

        }
    }
}