using System;

namespace PartialMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee wayner = new Employee();
            System.Console.WriteLine(wayner.EmpId);
        }
    }

    public partial class Employee
    {
        public Employee() 
        { 
            this.GenerateEmployeeId();
        }
        public int EmpId { get; set; }
        public string Name { get; set; }

        partial void GenerateEmployeeId();
    }

    public partial class Employee
    {
        partial void GenerateEmployeeId()
        {
            Random rd = new Random();
            this.EmpId = rd.Next(1, 10);
        }
    }
}
