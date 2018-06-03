using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Mosh Hamedani ";
            // Formating
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("ToLower: '{0}'", fullName.Trim().ToLower());
            // Searching
            var index = fullName.IndexOf(' ');
            // Substring
            var firsName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("firstName: " + firsName);
            Console.WriteLine("lastName: " + lastName);
            // Splitting
            var names = fullName.Split(' ');

            Console.WriteLine("firstName: " + names[0]);
            Console.WriteLine("lastName: " + names[1]);
            // Replacing
            Console.WriteLine(fullName.Replace("Mosh","Hung"));
            // Null cheking
            if(string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("IsValid");
            }
            // Convert
            var str = "25";
            var i = Convert.ToInt32(str);
            Console.WriteLine(i);

            float price = 29.99f;
            Console.WriteLine( price.ToString("C"));
        }
    }
}
