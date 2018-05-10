using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            int result = 0;
            string str = ("racecar");
            result = isPalindrome(str);
            Console.WriteLine(result);
        }

        public static string expandAroundCenter(string s, int c1, int c2)
        {
            int l = c1, r = c2;
            int n = s.Length;
            //while (l > -1 && r < n && s[l] == s[r])
            while (l >= 0 && r <= n - 1 && s[l] == s[r])
            {
                l--;
                r++;
            }
            return s.Substring(l + 1, r - l - 1);
        }

    }



}
