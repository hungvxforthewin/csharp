using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeledate
{
    /// <summary>
    /// Delegate, callback in dot Net
    /// ứng dụng cho làm giao diện
    /// </summary>

    public delegate int Caculator(int a, int b);
    public delegate void Show();
    class Program
    {
        static void Main(string[] args)
        {
            // basic
            Console.WriteLine(Human.Sum(1, 9));
            Human a = new Human();
            a.Display();
            
            // using delegate
            Caculator x = Human.Sum;
            Console.WriteLine(x(1, 9));
            Show y = a.Display;
            y();
            Console.ReadLine();
            // delegate có sẵn trong dotNet
            Func<int, int, int> func = Human.Sum;
            Action action = a.Display;
            Predicate<int> predicate = Human.Check;
        }
    }
    class Human
    {
        /// <summary>
        /// method thường, method static
        /// </summary>
        
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public void Display()
        {
            Console.WriteLine("Hello Delegate");
        }
        public static bool Check(int x)
        {
            if(x < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
