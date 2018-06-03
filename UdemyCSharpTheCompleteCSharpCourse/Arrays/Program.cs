using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo cho mảng a
            int[] a = new int[5];
            for(int i =0;i<5;i++)
            {
                a[i] = new Random().Next(1, 10);
            }


            // Khai báo và khởi tạo cho mảng b
            int[] b = new int[] { 1, 2, 3, 4, 5 };
            //
            string[] c = { "vu", "xuan", "hung" };
        }
    }
}
