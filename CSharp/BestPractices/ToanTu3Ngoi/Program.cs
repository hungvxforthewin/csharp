using System;

namespace ToanTu3Ngoi
{
    class Program
    {
        static void Main(string[] args)
        {
            // đặt biến dưới dạng biểu thức
            // ernary Operator ?:
            bool a = 3 < 2;
            int b = a == true ? 10 : 1;
            System.Console.WriteLine(a); // false
            System.Console.WriteLine(b); // 1
        }
    }
}
