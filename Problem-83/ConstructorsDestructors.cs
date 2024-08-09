//using System;

//public class ConstructorsDestructors
//{
//    public static void Main(string[] args)
//    {
//        int total = 3;
//        Person[] strPersons = new Person[total];

//        for (int i = 0; i < total; i++)
//        {
//            strPersons[i] = new Person(Console.ReadLine());
//        }

//        for (int i = 0; i < total; i++)
//        {
//            Console.WriteLine(strPersons[i].ToString());
//        }
//    }

//    public class Person
//    {
//        public string strName 
//        {
//            get;
//            set; 
//        }

//        public Person(string nName)
//        {
//            strName = nName;
//        }

//        public override string ToString()
//        {
//            return "Hello! My name is " + strName;
//        }

//        ~Person()
//        {
//            strName = string.Empty;
//        }
//    }
//}

