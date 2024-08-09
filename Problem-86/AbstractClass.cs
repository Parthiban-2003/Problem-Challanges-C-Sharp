using System;

public class AbstractClass
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.SetName(Console.ReadLine());
        Console.WriteLine(dog.GetName());
        dog.Eat();
    }

    public abstract class Animal
    {
        public string nName;

         public string GetName()
        {
            return nName;
        }
        public void SetName(string nNames)
        {
            nName = nNames;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}