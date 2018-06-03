using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Person();
            a.firstName = "Mosh";
            a.lastName = "Hamedani";
            a.Introduce();


            var b = new Calcurator();
            var result = b.Add(4, 5);
            Console.WriteLine(result);

            Console.WriteLine(CalcuratorStatic.Add(1, 4));

            int i = 1234;
            string s = i + "";

         }
    }
}
