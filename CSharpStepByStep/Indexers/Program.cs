using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            HtppCookie cookie = new HtppCookie();
            cookie["name"] = "Mosh";

            Console.WriteLine(cookie["name"]);
        }
    }
}
