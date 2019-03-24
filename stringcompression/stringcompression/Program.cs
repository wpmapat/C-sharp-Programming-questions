using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aabccccaaa";
            string result = ToCompressString(str);
            Console.WriteLine(result);
        }

        private static int CountCompress(string str)
        {
            int compressedLength = 0;
            int countConsecutive = 0;
            for(int i=0;i<str.Length;i++)
            {
                countConsecutive++;
                //If next char is diffrent from current then increase the length
                if(i+1 >=str.Length || str[i]!=str[i+1])
                {
                    compressedLength += 1+Convert.ToString(countConsecutive).Length;

                }
            }
            return compressedLength;
        }

        private static string ToCompressString(string str)
        {
            int finalLength = CountCompress(str);
            int[] arr1={ 0,1};
            Array.Sort(arr1);

            if (finalLength >= str.Length)
            {
                return str;
            }
            StringBuilder stringBuilder = new StringBuilder(finalLength);
            int countConsecutive = 0;
            for (int i = 0; i < str.Length; i++)
            {
                countConsecutive++;
                if (i + 1 >= str.Length || str[i] != str[i + 1])
                {
                    stringBuilder.Append(str[i]);
                    stringBuilder.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }
            return stringBuilder.ToString(); ;
        }
    }
}
