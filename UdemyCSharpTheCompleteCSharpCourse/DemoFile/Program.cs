using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\FileDemo\test.txt";
            // create
            if (File.Exists(path))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                var file = File.Create(path);
                Console.WriteLine(file.Name + " created");
            }
            Console.ReadKey();
        }
    }
}
