using System;
namespace AbstractS
{
    class Program
    {
        static void Main(string[] args)
        {
            Con c = new Con();
            c.Raw();
            c.SayHi();


            System.Console.ReadLine();
        }
    }

    abstract class Me
    {
        public void SayHi()
        {
            System.Console.WriteLine("Hi, i from abstract class");
        }

        abstract public void Raw();
    }

    class Con : Me
    {
        public override void Raw()
        {
            System.Console.WriteLine("I am abstract");
        }
    }
}
