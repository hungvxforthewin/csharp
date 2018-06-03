using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog d = new Dog();
            d.Attach();
            d.SayHi();
            d.Sit();
            d.Stay();
            d.run();
        }
    }

    public interface IAnimal
    {
       void run();
    }
    public interface IDog : IAnimal
    {
        void Stay();
        void Sit();
        void Attach();
        string DogName {get;set;}
    }
    public class Animal
    {
        string AnimalName;
        public void SayHi()
        {
            System.Console.WriteLine("Hello, i am animal");
        }
    }

    public class Dog : Animal,IDog,IAnimal
    {
        public string DogName { get; set; }

        public void Attach()
        {
           System.Console.WriteLine("Hello attaching");
        }

        public void run()
        {
            System.Console.WriteLine("Hello running");
        }

        public void Sit()
        {
            System.Console.WriteLine("Hello sitting");
        }

        public void Stay()
        {
            System.Console.WriteLine("Hello staying");
        }
    }
}
