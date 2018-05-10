using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "recede";
            string result = DuplicateEncoder(s);
            Console.WriteLine(result);
        }
        public static string DuplicateEncoder(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            s = s.ToLower();
            //s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {

                if (dict.ContainsKey(s[i]))
                {
                    //int value = dict[s[i]];
                    //value++;
                    dict[s[i]]++;
                }
                else
                {
                    dict.Add(s[i], 1);
                }
            }
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                //output += dict[s[i]] > 1 ? ")" : "(";
                if(dict[s[i]] > 1)
                {
                    output = output + ")";
                }
                else
                {
                    output = output + "(";
                }
            }
            return output;
        }
    }
}
