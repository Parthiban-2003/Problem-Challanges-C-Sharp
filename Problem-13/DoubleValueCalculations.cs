
﻿using System;

namespace Randoms
{ 
public class RandomNumberGenerator
{
    public static void Solutions()
    {
        Console.WriteLine("Enter their first value:");
        int nNum1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter their Second Number:");
        int nNum2 = Convert.ToInt32(Console.ReadLine());

        Random generator = new Random();
        int nNumber = generator.Next(nNum1, nNum2 + 1);
        

        Console.WriteLine(nNumber);
    }
   }
}
