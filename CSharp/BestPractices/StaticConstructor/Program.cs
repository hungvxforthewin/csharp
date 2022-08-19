using System;

namespace StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // static constructor luôn chạy đầu tiên, 1 lần khi static method, field đc call
            // StopWatch.DisplayInfo();
            // StopWatch.DisplayInfo();
            //System.Console.WriteLine(StopWatch.aeg); 

            // static construct được call 1 lần thì instance object đc create
            //Hàm tạo tĩnh chỉ được gọi một lần bất cứ khi nào phương thức tĩnh được sử dụng hoặc tạo một thể hiện lần đầu tiên
            StopWatch obj1 = new StopWatch();
            StopWatch obj2 = new StopWatch();


        }
    }

    public class StopWatch
    {
        // static constructor
        static StopWatch()
        {
            Console.WriteLine("Static constructor called");
            aeg = 10;
        }

        // instance constructor
        public StopWatch()
        {
            Console.WriteLine("Instance constructor called");
        }

        // static method
        public static void DisplayInfo()
        {
            Console.WriteLine("DisplayInfo called");
        }

        public static int aeg;

        // instance method
        public void Start() { }

        // instance method
        public void Stop() {  }
    }
}
