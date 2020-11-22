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
            // ==============================================================================create file
            // phân biệt sự khác nhau giữa file và fileInfo
            // kết hợp folder directory, directoryInfo và file, fileInfo
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("File exists");
            //}
            //else
            //{
            //    var file = File.Create(path);
            //    Console.WriteLine(file.Name + " created");
            //}
            //================================================================================create text in file
            //string path01 = @"E:\FileDemo\test.txt";
            //if (File.Exists(path01))
            //{
            //    StreamWriter streamWriter = File.CreateText(path01);
            //    streamWriter.WriteLine("Hello world");
            //    Console.WriteLine("File writed!");
            //    streamWriter.Close();
            //}
            //else
            //{
            //    Console.WriteLine("File not exists");
            //}
            //================================================================================append text in file
            //string path02 = @"E:\FileDemo\test.txt";
            //if (File.Exists(path02))
            //{
            //    StreamWriter streamWriter = File.AppendText(path02);
            //    streamWriter.WriteLine("vu thanh hung");
            //    Console.WriteLine("File appended");
            //    streamWriter.Close();
            //}
            //else
            //{
            //    Console.WriteLine("File not exists");
            //}
            //=================================================================================open file
            //string path03 = @"E:\FileDemo\test.txt";
            //if (File.Exists(path03))
            //{
            //    StreamReader streamReader = File.OpenText(path03);
            //    string s = "";
            //    Console.WriteLine(streamReader.ReadToEnd());
            //    //while((s = streamReader.ReadLine()) != null)
            //    //{
            //    //    Console.WriteLine(s);
            //    //}
            //    streamReader.Close();
            //}
            //else
            //{
            //    Console.WriteLine("File not exists");
            //}
            //===================================================================================move file
            // chú ý folder của target
            string path04 = @"E:\FileDemo\test.txt";
            //string path05 = @"E:\FileDemo02";
            string path05 = @"E:\FileDemo02\test.txt";
            // using FileInfo
            FileInfo fileInfo = new FileInfo(path04);
            FileInfo fileInfoTo = new FileInfo(path05);
            // using File
            if (!File.Exists(path04))
            {
                Console.WriteLine(fileInfo.FullName + "not exists");
                File.Create(path04);
            }
            else
            {
                Console.WriteLine(fileInfo.FullName + " exists");
                //Console.ReadKey();
                //return;
            }
            // using Directory
            if (Directory.Exists(fileInfoTo.Directory.ToString()))
            {
                Console.WriteLine("File move exists");
                Console.ReadKey();
                return;
            }
            // using DirectoryInfo
            DirectoryInfo directoryInfo = new DirectoryInfo(fileInfoTo.Directory.ToString());// Hiểu cả test.txt là 1 folder
            if (directoryInfo.Exists)
            {
                Console.WriteLine(directoryInfo.FullName + " exists");
                Console.ReadKey();
                return;
            }
            else
            {
                // Dùng fileInfo để tạo folder, có thể dùng DirectoryInfo để tạo nhưng cần thêm path, dùng 1 path sẽ trùng với File.move()
                fileInfoTo.Directory.Create();
            }
            try
            {
                File.Move(path04, path05);
                Console.WriteLine(fileInfo.Name + " moved!");
            }
            catch (Exception ex)
            {

                throw;
            }
            
            Console.ReadKey();
        }
    }
}
