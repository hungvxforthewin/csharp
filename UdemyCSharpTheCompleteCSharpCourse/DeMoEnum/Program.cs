using System;

namespace DeMoEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = Color.Red.ToString();
            System.Console.WriteLine(str);
            Color cl = Color.black;
            System.Console.WriteLine((int)cl);
        }
    }
    enum Color
    {
        Red,
        black,
        white
    }
}
