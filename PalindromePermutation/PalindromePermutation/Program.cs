using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Time Complexity=o(n)
//Space Complexity=o(n)
namespace PalindromePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            bool result = IsPalindromePermutation(str);
            Console.WriteLine(result);
        }
        public static bool IsPalindromePermutation(string str)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            char[] char1 = str.ToCharArray();

            //Create a Dictionary
            for(int i=0;i<char1.Length;i++)
            {
                if (map.ContainsKey(char1[i]))
                {
                    map[char1[i]] += 1;
                }
                else
                {
                    map.Add(char1[i], 1);
                }
            }

            int charcount = 0;
            for(int i=0;i<map.Count;i++)
            {
                if(map[char1[i]]%2==1)
                {
                    charcount++;
                }
            }
            if(charcount>1)
            {
                return false;
            }
            return true;
        }

    }
}

