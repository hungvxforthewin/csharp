using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtensionMethod
{
    class Program
    {
        /// <summary>
        /// Tạo thêm các method nhưng Linq
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var name = "vu     thanh hung";
            Console.WriteLine(name.DemSoTu());
            Console.ReadLine();
        }
    }
    static class Demo
    {
        public static int DemSoTu(this string str)
        {
            string[] result = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return result.Length;
        }
    }
}
