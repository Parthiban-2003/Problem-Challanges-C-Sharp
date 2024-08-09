using System;

namespace Storeuser
{
    public static class StoreUserInput
    {
        public static void Solutions()
        {
            Console.WriteLine("What is Your Name?");
            string strName= Console.ReadLine();

            Console.WriteLine($"Nice to meet you,{strName}");
        }
    }
}
