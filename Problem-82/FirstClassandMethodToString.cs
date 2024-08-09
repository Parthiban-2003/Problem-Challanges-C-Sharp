//using System;
//using System.Data.Common;

//public class FirstClassandMethodToString
//{
//    public static void Main(string[] args)
//    {
//        int nTotal = 3;
//        Person[] nPersons = new Person[nTotal];

//        for (int i = 0; i < nTotal; i++)
//        {
//            nPersons[i] = new Person()
//            {
//                strName = Console.ReadLine()
//            };
//        }

//        for (int i = 0; i < nTotal; i++)
//        {
//            Console.WriteLine(nPersons[i].ToString());
//        }

//        Console.ReadLine();
//    }

//    public class Person
//    {
//        public string strName 
//        { 
//            get; 
//            set; 
//        }

//        public override string ToString()
//        {
//            return $"Hello, My Name is: {strName}";
//        }
//    }
//}