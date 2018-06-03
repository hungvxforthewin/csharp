using System;

namespace DeMoSealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog a = new Dog();
            // a.name = "Hung";
            // System.Console.WriteLine(a.name);
        }
    }

    Sealed class Animal
    {
        public string name;
    }

    class Dog : Animal
    {
        public string age;
    }
}
