using System;

namespace ConstReadOnlyDemo
{
    public class Program
    {
        //public static const int timeDateVariable = 10; // ko cần static, default là static
        public const int timeDateVariable = 10;
        public static readonly int thisYear = 2022;

        //public const DateTime classCreator = new DateTime(2000, 1, 1);
        public static void Main(string[] args)
        {
            //public const int newAge = 1;

            Console.WriteLine("Hello World!");
            const int age = 10;

            const MyClass obj1 = null; // valid
            //const MyClass obj2 = new MyClass();//lỗi ở lúc runtime???
            
            // compile-time constant: const (không đổi value ngay đoạn dịch mã nguồn)
            // compile-time cần phải build mới check
            // thường làm thành viên của class/struct, thân của method(ko có public)
            // là hằng số từ khi biên dịch (compile-time)
            // Một biến constant có thể được khởi tạo bởi một biểu thức nhưng phải đảm bảo các toán hạng trong biểu thức cũng phải là constant ngay tại thời điểm compile-time
            // được gán tất cả các  access modifiers như public, private, protected, internal

            // run-time constant: readonly (xác định khi run và sau đó không thay đổi nữa)
            // có được khi khởi tạo tại thời điểm khai bảo, hoặc trong constructor của class đó
            // thường làm thành viên của class/struct  
            // ko có trong thân hàm    
            var newObj = new MyClass(10);    
            System.Console.WriteLine(newObj.X1);
            //System.Console.WriteLine(MyClass.X2);
            System.Console.WriteLine(MyClass.X3);
            System.Console.WriteLine(MyNumber.X2);
            System.Console.WriteLine(MyNumber.X3);
        }

        void Calculate(int Z)
        {
            const int X = 10, X1 = 50;
            const int Y = X + X1; // no error, since its evaluated a compile time
            //const int Y1 = X + Z; // gives error, since its evaluated at run time
        }
    }

    public class MyClass
    {
        readonly int X = 10; // Khởi tạo lúc khai báo
        public readonly int X1;
        //public static readonly int X2;
        public static readonly int X3 = 11;
        public MyClass(int x1)
        {
            X1 = x1; // khởi tạo lúc chạy
            // X2 = x1;
            // A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)
        }
    }

    public class MyNumber
    {
        // define readonly là static
        public static readonly int X2 = 12;
        public static readonly int X3;
        // static constructor not need param
        static MyNumber()
        {
            X2 = 14;
            X3 = 17;
        }
        public MyNumber(int Z)
        {

        }
    }
}
