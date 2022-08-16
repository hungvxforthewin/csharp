using System;

namespace ConstReadOnlyDemo
{
    public class Program
    {
        public const int timeDateVariable = 10;
        public static readonly int thisYear = 2022;

        //public const DateTime classCreator = new DateTime(2000, 1, 1);
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            const int age = 10;
            
            // compile-time constant: const (không đổi value ngay đoạn dịch mã nguồn)
            // compile-time cần phải build mới check
            // thường làm thành viên của class/struct, thân của method(ko có public)

            // run-time constant: readonly (xác định khi run và sau đó không thay đổi nữa)
            // thường làm thành viên của class/struct  
            // ko có trong thân hàm         
        }
    }
}
