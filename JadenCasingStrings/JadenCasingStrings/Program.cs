using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JadenCasingStrings
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string phrase = "How can mirrors be real if our eyes aren't real";
            string result = ToJadenCase1(phrase);
            Console.WriteLine(result);
        }
        public static string ToJadenCase(this string phrase)
        {
            var titleCaseStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);
            return titleCaseStr;
        }
        public static string ToJadenCase1(this string phrase)
        {
            char[] c = phrase.ToArray();
            bool CapitalNext = true;
            string o = null;

            foreach (char ch in phrase)
            {

                if (CapitalNext)
                    o += ch.ToString().ToUpper();
                else
                    o += ch.ToString();

                CapitalNext = false;

                if (char.IsWhiteSpace(ch))
                {
                    CapitalNext = true;
                }
            }
            return o;
        }
    }
}
