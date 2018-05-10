using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Reverse_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "krish21an";
            string result = ReverseLetter(str);
            Console.WriteLine(result);
        }
        public static string ReverseLetter(string str)
        {
            //str.Text =
            //Regex.Replace(txtString.Text, "[^a-zA-Z]", "");
            Regex rgx = new Regex("[^a-zA-Z]");
            string str1 = rgx.Replace(str, "");
            char[] cArray = str1.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
