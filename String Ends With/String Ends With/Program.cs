using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Ends_With
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "samurai";
            string str2 = "ra";
            bool result = Solution(str1, str2);
            Console.WriteLine(result);
        }
        public static bool Solution(string str1, string str2)
        {
            int i = str1.Length - 1;
            int j = str2.Length - 1;
            while(j>-1)
            {
                if ((str1[i] != str2[j])&&(i==str1.Length))
                {
                    return false;
                }
                else
                    j--;
                    i--;
                
            }
            if (j == -1)
            {
                return true;
            }
            if (i == -1)
            {
                return false;
            }
            return true;
        }
    }
}
