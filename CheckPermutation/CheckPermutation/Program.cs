using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation
{
    class Program
    {
        static int noofchars = 256;
        static void Main(string[] args)
        {
            string str1 = "geeks";
            string str2 = "keegs";
            bool result = CheckPermutationByCountingChars(str1, str2);
            Console.WriteLine(result);
        }
        //Time Complexity O(n square). Since worst case time complexity of Quick Sort in quadratic.
        public static bool CheckPermutationBySorting(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            if (str1 != str2)
            {
                return false;
            }
            char[] str1_char = str1.ToCharArray();
            char[] str2_char = str2.ToCharArray();

            //Sort both arrays
            Array.Sort(str1_char);
            Array.Sort(str2_char);

            //Compare both the arrays
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1_char[i] != str2_char[i])
                {
                    return false;
                }
            }
            return true;
        }
        //Time Complexity O(n)
        public static bool CheckPermutationByCountingChars(string str1, string str2)
        {
            int[] count1 = new int[noofchars];
            int[] count2 = new int[noofchars];

            char[] str1_char = str1.ToCharArray();
            char[] str2_char = str2.ToCharArray();

            for (int i = 0; i < count1.Length; i++)
            {
                count1[i] = 0;
            }
            for (int i = 0; i < count2.Length; i++)
            {
                count2[i] = 0;
            }
            for (int i = 0; i < str1_char.Length; i++)
            {
                count1[str1[i]]++;
            }
            for (int i = 0; i < str2_char.Length; i++)
            {
                count2[str2[i]]++;
            }
            if (count1.Length != count2.Length)
            {
                return false;
            }
            // Compare count arrays 
            for (int i = 0; i < noofchars; i++)
            {
                if (count1[i] != count2[i])
                    return false;
            }
            return true;
        }
    }
}
