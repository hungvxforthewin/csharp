using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\images";
            // 1 type file, all file in folder
            //string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            //foreach (var item in files)
            //{
            //    Console.WriteLine(item);
            //}

            // mutil type file, all file in folder
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("png")).ToList();
            foreach (var item in files)
            {
                Console.WriteLine(item);
            }
            //Console.ReadKey();

            // mutil file, get file name
            Console.WriteLine("**********************-************************");
            var allowedExtensions = new [] {".doc", ".docx", ".pdf", ".ppt", ".pptx", ".xls", ".xslx"}; 
            var allFiles = Directory
                .GetFiles(path, "*.*", SearchOption.AllDirectories)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith))
                .ToList();
            foreach (var item in allFiles)
            {
                Console.WriteLine(Path.GetFileName(item));
            }

           
        }
    }
}
