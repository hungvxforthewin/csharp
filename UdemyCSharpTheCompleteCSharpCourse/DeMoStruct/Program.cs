using System;

namespace DeMoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Employee e = new Employee();
            e.name = "Hung";
            e.job = "IT";
            e.Salary = 3000;

            System.Console.WriteLine($"Name is {e.name} job: {e.job} salary: {e.Salary}");
            e.HiSay();
        }
    }

    struct Employee
    {
        public string name;
        public string job;
        private decimal salary;
        public decimal Salary
        {
            get { return salary;}
            set {salary = value;}
        }
        public void HiSay()
        {
            System.Console.WriteLine("Hello from method in struct");
        }
    }
}
