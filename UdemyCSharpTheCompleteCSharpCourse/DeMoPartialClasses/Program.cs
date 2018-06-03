using System;

namespace DeMoPartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Animal a = new Animal();
            a.name = "Hung";
            a.salary = 1000000;
            a.Display();
        }
    }

    //
    partial class Animal
    {
        public Animal()
        {
            age = 23;
        }
        public string name;
        public int age;
        public void Display()
        {
            System.Console.WriteLine($"Hello !, my name is {name}, i {age} year old.");
        }
    }

    partial class Animal
    {
        public int salary;
    }
}
