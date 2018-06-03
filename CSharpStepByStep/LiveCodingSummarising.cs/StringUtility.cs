using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingSummarising.cs
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLenght = 20)
        {
            if (text.Length < maxLenght)
                return text;

            var words = text.Split(' ');
            var totalCharactor = 0;
            var summaryWord = new List<string>();

            foreach (var word in words)
            {
                summaryWord.Add(word);

                totalCharactor += word.Length + 1;
                if (totalCharactor > maxLenght)
                    break;
            }

            return string.Join(" ", summaryWord) + "...";

        }
    }
}
