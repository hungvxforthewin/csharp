using System;

namespace OverloadingOverride
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Overloading");
            int a;
            a = Sum.tinhtong(1, 2);
            System.Console.WriteLine("a: " + a);


            // Override
            Dog grass = new Dog();
            grass.actionAnimal();
            grass.soundAnimal();

            Cat grass1 = new Cat();
            grass1.actionAnimal();
            grass1.soundAnimal();
        }
    }

    class Dog : Animal
    {
        public override void soundAnimal()
        {
            // gọi lại func ở base
            // fix version dotnet ở global.json, .csproj (sửa lại version dotnet đã install)
            base.soundAnimal();
            System.Console.WriteLine("Gau Gau");
        }
         public void actionAnimal()
        {
            System.Console.WriteLine("Run");
        }
    }

    class Cat : Animal
    {
        public override void soundAnimal()
        {
            base.soundAnimal();
            System.Console.WriteLine("Meo Meo");
        }
         public void actionAnimal()
        {
            System.Console.WriteLine("Jump");
        }
    }
}
