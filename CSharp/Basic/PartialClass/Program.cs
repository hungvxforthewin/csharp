using System;

namespace PartialClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // props
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
    }
    
    // method and constructor
    public partial class Employee
    {
        //constructor
        public Employee(int id, string name){
            this.EmpId = id;
            this.Name = name;
        }

        public void DisplayEmpInfo() {
            Console.WriteLine(this.EmpId + " " + this.Name);
        }
    }
}
