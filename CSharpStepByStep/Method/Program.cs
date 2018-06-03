using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ab = 2;
            Weirdo weirdo = new Weirdo();
            weirdo.WeirdoThing(out ab);

            Console.WriteLine(ab);
        }
    }

    public class Weirdo
    {
        public void WeirdoThing(out int a)
        {
            a = 1;
        }
    }
}
