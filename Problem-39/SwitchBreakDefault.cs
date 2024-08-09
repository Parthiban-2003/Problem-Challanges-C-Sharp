using System;

namespace sitch
{
    public static class SwitchBreakDefault
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter their Number of X:");
            int nX = Convert.ToInt32(Console.ReadLine());

            switch(nX)
            {
                case 10:
                    Console.WriteLine("A+");
                    break;

                case 9:
                    Console.WriteLine("A");
                    break;

                case 8:
                case 7:
                    Console.WriteLine("B");
                    break;

                case 6:
                    Console.WriteLine("C");
                    break;

                case 5:
                    Console.WriteLine("E");
                    break;

                default:
                    Console.WriteLine("F");
                    break;

            }
        }
    }
}
