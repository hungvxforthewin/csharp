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
            if (fl.Exists)
            {                
                Console.WriteLine("file created");
            }
            else
            {
                Console.WriteLine(fl.Name + " file not exists");
                fl.Create(); // tương tự File
            }
            // create text
            //FileInfo fl2 = new FileInfo(path);
            //StreamWriter streamWriter = fl2.CreateText();
            //streamWriter.WriteLine("Hello world");
            //Console.WriteLine("Writed text in file");
            //streamWriter.Close();
            // open text
            //FileInfo fl3 = new FileInfo(path);
            //StreamReader streamReader = fl3.OpenText();
            //string s = "";
            //while((s = streamReader.ReadLine()) != null)
            //{
            //    Console.WriteLine(s);
            //}
            // append text --> same create text
            FileInfo fl4 = new FileInfo(path);
            StreamWriter streamWriter1 = fl4.AppendText();
            streamWriter1.WriteLine("Vu");
            streamWriter1.WriteLine("Thanh");
            streamWriter1.WriteLine("Hung");
            streamWriter1.Write("Không xuống dòng");
            streamWriter1.Close();
            Console.ReadKey();
        }
    }
}
