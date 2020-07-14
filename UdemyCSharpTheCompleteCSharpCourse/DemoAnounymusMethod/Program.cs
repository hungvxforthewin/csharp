using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAnounymusMethod
{
    /// <summary>
    /// Using delegate func no name
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> funcSum = delegate (int a, int b) { return a + b; };
            Console.WriteLine(funcSum(5, 5));
            Console.ReadLine();
        }
    }
}
