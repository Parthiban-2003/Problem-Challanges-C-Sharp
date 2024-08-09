using System;

namespace Letter
{
    public static class ReverseChars
    {
        public static void Solutions()
        {
            Console.WriteLine("Enter a first letter:");
            char a = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a second letter:");
            char b = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter a third letter:");
            char c = Convert.ToChar(Console.ReadLine());

         
            Console.WriteLine($"{c} {b} {a}");
        }
    }
}
