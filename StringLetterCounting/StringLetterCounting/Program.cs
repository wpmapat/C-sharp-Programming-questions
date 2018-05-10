using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLetterCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is a test sentence";
            string result = StringLetterCount(str);
            Console.WriteLine(result);
        }
        public static string StringLetterCount(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            bool val = false;
            if (str=="")
            {
                return "";
            }
            val = IsDigitsOnly(str);
            if(val==true)
            {
                return "";
            }
            for(int i=0;i<str.Length;i++)
            {
                if(dict.ContainsKey(str[i]))
                {
                    dict[str[i]]++;
                }
                else
                {
                    dict.Add(str[i], 1);
                }
            }
            return Convert.ToString(dict);
        }
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
