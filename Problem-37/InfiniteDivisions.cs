using System;

namespace Div
{
    public static class InfiniteDivisions
    {
        public static void Solutions()
        {
            int nNum1, nNum2;

            do
            {
                Console.WriteLine("Enter their number1");
                nNum1 = Convert.ToInt32(Console.ReadLine());

                if (nNum1 != 0)
                {
                    Console.WriteLine("Enter their Number2:");
                    nNum2 = Convert.ToInt32(Console.ReadLine());

                    if (nNum2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Division:{nNum1 / nNum2}");
                        Console.WriteLine($"Remainder:{nNum1 % nNum2}");
                        Console.WriteLine();
                    }
                }
            } while (nNum1 != 0);
            Console.WriteLine("GOOD BYE..!");


           // int nX;
           // int nY;


           // do
           // {
           //     Console.WriteLine("Enter their number X:");
           //     nX = int.Parse(Console.ReadLine());


           //     if (nX == 0)
           //     {
           //         Console.WriteLine("Good Bye..!!");
           //         break;
           //     }

           //     Console.WriteLine("Enter their number Y:");
           //     nY = int.Parse(Console.ReadLine());

           //     if (nX != 0 && nY != 0) 
           //     {
           //         int div = nX / nY;
           //         int rest = nX % nY;

           //         Console.WriteLine($"DIV:{div}");
           //         Console.WriteLine($"REST:{rest}");
           //     }
           //    else
           //     {
           //         Console.WriteLine("Can't divied by zero");
           //     }

           // } while (nX != 0 || nY!= 0);

        }
    }
}
