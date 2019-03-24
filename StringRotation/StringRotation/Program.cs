using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRotation
{
    class Program
    {
        //TimeComplexity=o(n)
        static void Main(string[] args)
        {
            string s1 = "waterbottle";
            string s2 = "erbottlewat";
            bool result = IsRotation(s1, s2);
            Console.WriteLine(result);
        }

        private static bool IsRotation(string s1, string s2)
        {

            return (s1 + s1).IndexOf(s2) > -1 && (s1.Length == s2.Length);
        }
    }
}
