using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "true";

                int i = int.Parse(number);

                int j = Convert.ToInt32(number);

                //int k = int.TryParse()

                Console.WriteLine(i);

                Console.WriteLine(j);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
