using System;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Từ khóa static được sử  dụng để tạo một biến hoặc một thành phần tĩnh
            // giá trị của nó sẽ được chia sẻ cho toàn bộ các đối tượng và không gắn vào một đối tượng cụ thể nào (ko call đc qua instance object)
            // áp dụng được cho cả class, fields, properties, operators, events, constructor
        
            // If the static keyword is applied to a class, all the members of the class must be static.
            // Phương thức static chỉ có thể truy cập các thành phần static khác  trong class
            // Các static properties được sử dụng để set và get giá trị cho các giá trị của biến static trong class
            // Static constructor không thể có tham số, Không thể áp dụng các access modifiers cho static constructor,  luôn có một default constructor public để khởi tạo các biến static cho class

            // call class static
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result); 
            System.Console.WriteLine(Calculator._resultStorage);

            // class non-static
            //
            // Read the static properties.
            //
            Console.WriteLine(NonCalculator.DayNumber);
            Console.WriteLine(NonCalculator.DayName);
            //
            // Change the value of the static bool property.
            //
            NonCalculator.Finished = true;
            Console.WriteLine(NonCalculator.Finished);

            // static property

            NonCalculator nonObj = new NonCalculator();
            NonCalculator.Name = "HungVX";
            System.Console.WriteLine(NonCalculator.Name);

            // static field
            StopWatch sw1 = new StopWatch();
            StopWatch sw2 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances); //2 
                
            StopWatch sw3 = new StopWatch();
            StopWatch sw4 = new StopWatch();
            Console.WriteLine(StopWatch.NoOfInstances);//4
        }
    }

    class MyClass
    {
        static int X = 10;
        int Y = 20;
        public static void Show()
        {
            Console.WriteLine(X);
            //Console.WriteLine(Y); //lỗi bởi vì static method chỉ truy cập được biến static
        }
    }

    // class static
    public static class Calculator
    {
        public static int _resultStorage = 0;
        
        public static string Type = "Arithmetic";

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Store(int result)
        {
            _resultStorage = result;
        }
    }

    // class non-static
    public class NonCalculator
    {
        // static cannot be accessed with an instance reference
        // public NonCalculator(string name)
        // {
        //     this.name = name;
        //     Count++;
        // }
        // static method
        static void display()
        {
            // staff
        }

        // static field 
        static int age = 10;
        private static string name;
        // static property

        public static string Name
        {
            get
            {
                return name; // not this.name
            }
            set
            {
                name = value;
            }
        }

        public static int Count
        {
            get;
            private set;
        }
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }

        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }

        public static bool Finished
        {
            get;
            set;
        }

    }    

    // static field
    public class StopWatch
    {
        public static int NoOfInstances = 0;
        
        // instance constructor
        public StopWatch()
        {
            StopWatch.NoOfInstances++;
        }
    }

    // static method
    // static constructor
}
