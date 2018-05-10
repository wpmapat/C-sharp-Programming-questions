using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace ConvertStringToCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "the_stealth_warrior";
            string result = ToCamelCase(str);
            Console.WriteLine(result);
        }
        public static string ToCamelCase(string str)
        {
            char[] delimitors = {'-','_' };
            string[] strarray;
            strarray = str.Split(delimitors);
            for (int i = 1; i < strarray.Length; i++)
            {
              strarray[i] = Capitalize(strarray[i]);
            }
           return String.Join("", strarray);
        }
        public static string Capitalize(string str)
        {
            char ch=Char.ToUpper(Convert.ToChar(str[0]));
            string result = ch + str.Substring(1);
            return result;
        }
    }
}
