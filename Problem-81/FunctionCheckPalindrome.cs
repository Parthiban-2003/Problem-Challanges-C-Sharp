//using System;

//public class CheckPalindrome
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Enter a string to check if it's a palindrome:");
//        string strText = Console.ReadLine();

//        if (IsPalindrome(strText))
//        {
//            Console.WriteLine($"'{strText}' is a palindrome.");
//        }
//        else
//        {
//            Console.WriteLine($"{strText} is not a palindrome.");
//        }

//    }

//    public static bool IsPalindrome(string strText)
//    {

//        int nNum = 0;
//        int nTest = strText.Length - 1;


//        while (nNum < nTest)
//        { 
//            if (strText[nNum] != strText[nTest])
//            {
//                return false;
//            }

//            nNum++;
//            nTest--;
//        }

//        return true;
//    }
//}



