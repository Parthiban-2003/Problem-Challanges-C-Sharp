//using System;

//public class ClassPersonStudentTeacher
//{
//    public static void Main()
//    {
//        Person MyPerson = new Person();
//        MyPerson.Greet();

//        Student MyStudent = new Student();
//        MyStudent.SetAge(21);
//        MyStudent.Greet();
//        MyStudent.ShowAge();
//        MyStudent.Study();

//        Teacher MyTeacher = new Teacher();
//        MyTeacher.SetAge(30);
//        MyTeacher.Greet();
//        MyTeacher.Explain();
//    }
//}

//public class Person
//{
//    public int nAge;

//    public void Greet()
//    {
//        Console.WriteLine("Hello..!");
//    }

//    public void SetAge(int n)
//    {
//        nAge = n;
//    }
//}

//public class Student : Person
//{
//    public void Study()
//    {
//        Console.WriteLine("I am studying..!!");
//    }

//    public void ShowAge()
//    {
//        Console.WriteLine($"My age is {nAge} years old.");
//    }
//}

//public class Teacher : Person
//{
//    public void Explain()
//    {
//        Console.WriteLine("I am explaining");
//    }
//}