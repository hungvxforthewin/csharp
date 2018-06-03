using System;

namespace DeMoNestedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Mother a = new Mother();
            a.age = 20;
            Mother.Son b = new Mother.Son();
            b.Display();
        }
    }

    public class Mother
    {
        public string name;
        public int age;

        private string arrow;

        public class Son
        {
            private decimal salary;
            public void Display()
            {
                System.Console.WriteLine("Hello, i am son");
            }
        }
    }
}
