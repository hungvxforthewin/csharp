using System;

namespace objectDynamicVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // var, dynamic and object
            var a1 = "hello, world";
            //a1 = 10;
            // ngầm hiểu implicit là string type, sử dụng đc các method
            // ko assign value lần nữa
            int lent = a1.Length;
            System.Console.WriteLine(lent);

            object a2 = "hello, world";
            a2 = 10;
            
            // ko ngầm hiểu implicit là string type, ko sử dụng đc các method
            // base của mọi type: ToString(), GetType(), Equal(), GetHashCode()
            // assign value lần nữa

            dynamic a3 = "hello, world";
            int lentA3 = a3.Length;
            System.Console.WriteLine(lentA3);
            // dynamic ko check lỗi khi compiler time
            // sử dụng đc các method nhưng sẽ check khi runtime
        }
    }
}
