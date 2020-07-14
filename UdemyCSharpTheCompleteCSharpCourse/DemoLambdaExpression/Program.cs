using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLambdaExpression
{
    /// <summary>
    /// Dùng cho Linq, hoặc delegate
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> func = (a, b) => { return a + b; };
            Console.WriteLine(func(5, 5));
            Console.ReadLine();
        }
    }
}
