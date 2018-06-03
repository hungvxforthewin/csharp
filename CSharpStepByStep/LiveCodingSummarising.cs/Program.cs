using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarising.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really";
            var summer = StringUtility.SummerizeText(sentence, 20);      

            Console.WriteLine(summer);         
        }
    }
}
