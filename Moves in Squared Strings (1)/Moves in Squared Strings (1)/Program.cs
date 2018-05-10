using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moves_in_Squared_Strings__1_
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string s = "lVHt\nJVhv\nCSbg\nyeCt";
            string result = Oper(HorMirror, s);
            Console.WriteLine(result);
        }
        public static string VertMirror(string str)
        {
            string[] arrstr1 = str.Split('\n');
            for (int i = 0; i < arrstr1.Length; i++)
            {
                arrstr1[i] = ToReverse(arrstr1[i]);
            }
            return string.Join("\n", arrstr1);

        }
        public static string HorMirror(string str)
        {
            string[] arrstr1 = str.Split('\n');
            Array.Reverse(arrstr1);
            return string.Join("\n", arrstr1);
        }
        //Func Delegate
        public static string Oper(Func<string,string> fct, string s)
        {
            return fct(s);
        }
        public static string ToReverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}
