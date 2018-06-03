using System;

namespace DemoNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyNamespace.MyClass a = new MyNamespace.MyClass();
            a.Display();

        }
    }
}

namespace MyNamespace
{
    class MyClass
    {
        public string name;
        public int age;
        public MyClass()
        {
            name = "Hung";
            age = 23;
        }

        public void Display()
        {
            System.Console.WriteLine($"My namespace: name {name}, age {age}");
        }
    }
}
