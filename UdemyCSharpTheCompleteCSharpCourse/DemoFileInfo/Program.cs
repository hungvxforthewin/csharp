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

            Console.WriteLine(fl4.FullName);
            Console.WriteLine(fl4.Length);
            Console.WriteLine(fl4.Name);
            Console.WriteLine(fl4.DirectoryName);
            Console.WriteLine(fl4.Directory);
            Console.WriteLine(fl4.Extension);
           
            // move file, check required
            // đk file2.txt ko đc exists, file1 phải có trước, move sẽ lấy theo name file đc khai báo theo path6
            //string path5 = @"E:\folder1\file1.txt";
            //string path6 = @"E:\folder2\file2.txt";
            //FileInfo fl5 = new FileInfo(path5);
            //FileInfo fl6 = new FileInfo(path6);
            //fl5.MoveTo(path6);
            //Console.WriteLine("{0} was moved to {1}.", path5, path6);


            // copy file
            // same như move nhưng file1 sẽ ko mất, mà có copy
            string path5 = @"E:\folder1\file1.txt";
            string path6 = @"E:\folder2\file2.txt";
            FileInfo fl5 = new FileInfo(path5);
            FileInfo fl6 = new FileInfo(path6);
            fl5.CopyTo(path6);
            Console.WriteLine("{0} was copyed to {1}.", path5, path6);
            Console.ReadKey();
        }
    }
}
