using System;
using System.Collections.Generic;

namespace DeMoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Humen a = new Humen();
            //a.Id = 2;
            System.Console.WriteLine(a.Id);
            a.Display();

            Animal b = new Animal
            {
                Id = 1,
                Name = "Dog",
                TypeAnimal = "Dog"
            };

             Animal c = new Animal();
             b.Id = 2;
             b.Name = "Hung";
             b.TypeAnimal = "Humen";

            List<Animal> lstAnimal = new List<Animal>
            {
                new Animal {Id = 3,Name = "Tiger",TypeAnimal="Tiger"},
                new Animal {Id = 4,Name = "Mouse",TypeAnimal="Mouse"},
                new Animal {Id = 5,Name = "Chicken",TypeAnimal="Chicken"}
            };
        }
    }
    #region -object humen Id read only
    public class Humen
    {
        public int Id {get;}
        public string name {get;set;}
        public int salary {get;set;}

        public Humen()
        {
            Id = 1;
            name = "admin";
            salary = 3000;
        }

        public void Display()
        {
            System.Console.WriteLine("Hello, i am object");
        }

    }
    #endregion


    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TypeAnimal { get; set; }

        public Animal()
        {
            
        }

        public void Display()
        {
            System.Console.WriteLine("Hello, i am obj enimal");
        }

        public void Display(Animal m)
        {

        }
    }

}
