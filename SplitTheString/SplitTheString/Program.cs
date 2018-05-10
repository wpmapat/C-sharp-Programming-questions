using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            string[] result = Solution(str);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static string[] Solution (string str)
        {
            int length = str.Length;
            string[] emptystringarray = new string[0]; 
            if (length==0)
            {
                return emptystringarray;
            }
            if(length%2!=0)
            {
                str = str + "_";
            }
            List<string> list = new List<string>();
            int i = 0;
            while(i <str.Length)
            {
                string result = str.Substring(i, 2);
                list.Add(result);
                i = i + 2;
            }
            return list.ToArray();
       }
    }

}
