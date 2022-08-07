using System;
using AccessModifierTutorial;

namespace AccessModifers
{
    class Program
    {
        static void Main(string[] args)
        {
            // define new instance of class, object
            Person a = new Person("Wayner");

            // private constructor
            // Animal b = new Animal("Bob");
            Console.WriteLine("Hello World!");
        }
    }
}
