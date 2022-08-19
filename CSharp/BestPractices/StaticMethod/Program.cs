using System;

namespace StaticMethod
{
    class Program
    {
        static int couter = 0;
        string name = "Demo";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            name = "New Demo Program"; //Error: cannot access non-static members
            SetRootFolder(@"C:\MyProgram"); //Error: cannot call non-static method

            counter++; // can access static fields
            Display("Hello World!"); // can call static methods
        }
        
        // static method
        static void displayName(string name)
        {
            System.Console.WriteLine(name);
        }
        public void setRootFolder(string path)
        {

        }
    }
}
