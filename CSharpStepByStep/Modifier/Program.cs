using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person pe = new Person(new DateTime(1995, 12, 14));

            // pe.Birthday = new DateTime(1995, 12, 14);

            Console.WriteLine(pe.Age);
        }
    }
}
