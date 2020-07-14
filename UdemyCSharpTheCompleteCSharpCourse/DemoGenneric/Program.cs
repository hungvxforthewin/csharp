using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGenneric
{
    /// <summary>
    /// Genneric 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class CollectionUserDefine<T>
    {
        T[] a;
        int count = 0;
        public CollectionUserDefine(int n)
        {
            a = new T[n];
        }
        public void Add(T x)
        {
            if(count < a.Length)
            {
                a[count] = x;
                count++;
            }
        }
        public void Display()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
    class Utility
    {
        /// <summary>
        /// Dùng đc cho nhiều type, type T
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap<T>(T a, T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CollectionUserDefine<string> B = new CollectionUserDefine<string>(6);
            B.Add("vu");
            B.Add("thanh");
            B.Add("hung");
            B.Add("phuong");
            B.Add("nam");
            B.Add("do");

            CollectionUserDefine<int> A = new CollectionUserDefine<int>(6);
            A.Add(6);
            A.Add(5);
            A.Add(2);
            A.Add(1);
            A.Add(7);
            A.Add(8);
            
            A.Display();
            B.Display();
            // Genneric có sẵn trong namespace ICollection
            List<int> lstA = new List<int>();
        }
    }

}
