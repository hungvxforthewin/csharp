using System;

namespace DeMoThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person ps = new Person();
            ps.Display("thanh","lam");
        }
    }
    class Person
    {
        public string _firstName;
        public string _lastName;

        public void Display(string firstName, string lastName)
        {
            System.Console.WriteLine(firstName + "" + lastName);
            System.Console.WriteLine(this._firstName + "" + this._lastName);
        }

        public Person()
        {
            _firstName = "Vu";
            _lastName = "hung";
        }
    }
}
