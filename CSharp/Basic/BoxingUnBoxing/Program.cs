using System;

namespace BoxingUnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Boxing");

            int a = 10;
            int b = a;
            b = 100;

            object c = a; // boxing
            c = 111;

            int j = (int)c; // unboxing

            System.Console.WriteLine("a: " + a);
            System.Console.WriteLine("b: " + b);
            System.Console.WriteLine("c: " + c);

        }
    }
}
