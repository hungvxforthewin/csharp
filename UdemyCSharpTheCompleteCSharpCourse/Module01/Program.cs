using System;

namespace Module01
{
    class Program
    {
        /// <summary>
        /// Fundamental C# Part 1
        /// 
        /// -IDE, key word
        /// -Variables
        /// -Datatypes: note var
        /// -Loops
        /// -List<>, Array<>, IEnumbrable<>
        /// -Arithmetic Operators
        /// -Logical Operators
        /// -Comparison Operator
        /// -Systax basic
        /// -Libary .NET
        /// *OOP
        /// *Class
        /// *Method
        /// *Filed
        /// *Property
        /// *Encapsulation
        /// *Inheritance
        /// *Polymorphism
        /// *Abstraction
        /// -Linq Ranger, ADO.NET, SQL Server
        /// -Extension method
        /// -Delegate
        /// -Generic
        /// -Lambda Expression
        /// -IEnumbrable & yield
        /// -Event
        /// -Collection
        /// -Wait, Task<>
        /// -Multithreading
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var a = "123";
            var b = 1;
            float c;
            c = (float)b;
            int d = Convert.ToUInt16(a);
            var e = b.ToString();

            Console.WriteLine("Convert int {0} to float {1} ",b,c);
            Console.WriteLine("Convert string to int {0}",d);
            Console.WriteLine("Convert int to string " + e);
            Console.ReadLine();
        }
    }
}
