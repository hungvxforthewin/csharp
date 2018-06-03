using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>();

            while(true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exit)");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Uniques number: ");
            foreach(var item in uniques)
            {
                Console.WriteLine(item);
            }
        }
    }
}
