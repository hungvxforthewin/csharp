using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\images";
            // read folder, read file in folder, not folder root
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            var x = directoryInfo.GetDirectories();
            foreach (var item in x)
            {
                Console.WriteLine(item.FullName);
                foreach (var file in item.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    Console.WriteLine("--" + file.Name);
                }
            }
            Console.WriteLine("-------------Read folder root------------------");
            var y = directoryInfo.GetFiles();
            foreach (var item in y)
            {
                Console.WriteLine(item.FullName);
            }
            
            // create directoty, sub_directory, move directory, delete
            // create
            Console.WriteLine("-----------------Create------------------");
            string pathCreate = @"E:\MyFolder";
            DirectoryInfo fl = new DirectoryInfo(pathCreate);
            if (!fl.Exists)
            {
                fl.Create();
                {
                    Console.WriteLine("Directory has been created");
                }
            }
            else
            {
                Console.WriteLine("Directory has been exists");
            }
            // create sub_directory 
            Console.WriteLine("-----------------Create sub------------------");
            fl.CreateSubdirectory("new folder");
            Console.WriteLine("Sub directory has been created");
            // move 
            Console.WriteLine("-----------------Create move------------------");
            string pathMove1 = @"E:\test1";
            string pathMove2 = @"E:\test2";// phải chưa exists
            DirectoryInfo f1 = new DirectoryInfo(pathMove1);
            DirectoryInfo f2 = new DirectoryInfo(pathMove2);
            string destinationPath = Path.Combine(@"E:\", "test2");
            if (f1.Exists && !f2.Exists)
            {
                f1.MoveTo(destinationPath);
                Console.WriteLine("Directory has been Moved");
            }
            else
            {
                Console.WriteLine("Directory has been not Moved");
            }
            // delete
            Console.WriteLine("-----------------Create delete------------------");
            string pathDel = @"E:\test1";
            DirectoryInfo f3 = new DirectoryInfo(pathDel);
            if (f3.Exists)
            {
                f3.Delete();
                Console.WriteLine("Directory has been Delete");
            }
            else
            {
                Console.WriteLine("Directory has been not Delete");
            }
            Console.ReadKey();
        }
    }
}
