using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoForeachYield
{
    class Program
    {
        /// <summary>
        /// Cách dùng Yield
        /// Được return trong for nếu dùng Yield
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Track tk = new Track();
            var lst = tk.GetName();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
    class Track
    {
        string[] names = { "vu", "thanh", "hung" };
        public IEnumerable<string> GetName()
        {
            for (int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}
