using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\MyFolder\test.txt";
            // file phải đã exists thì mới tạo để lấy thông tin file
            // create file 
            FileInfo fl = new FileInfo(path);
            fl.Create(); // tương tự File
            if (fl.Exists)
            {                
                Console.WriteLine("file created");
            }
            else
            {
                Console.WriteLine(fl.Name + " file not exists");
            }
            Console.ReadKey();
        }
    }
}
