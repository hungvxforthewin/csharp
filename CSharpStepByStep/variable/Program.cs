using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 10f;
            char character = 'a';
            string firstName = "Mosh";
            bool isWorking = true;


            Console.WriteLine(number);

            Console.WriteLine("{0}: ", count);

            Console.WriteLine($"{totalPrice}");

        }
    }
}
