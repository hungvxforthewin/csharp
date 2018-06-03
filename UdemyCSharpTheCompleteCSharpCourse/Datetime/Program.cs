using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDatetime = DateTime.Now;
            var formatDate = string.Format("Date is {0:yyyy MMMMM ddddddd}", myDatetime);
            //Console.WriteLine(myDatetime.ToShortDateString());

            

            Console.WriteLine(formatDate);
        }
    }
}
