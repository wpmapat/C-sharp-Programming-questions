using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urlify
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Mr John Smith    ";
            int length = str.Length;
            char[] str_char = str.ToCharArray();
            //string result = ToUrlify(str);
            string result = Urlify2(str_char,length);
            Console.WriteLine(result);
        }
        public static string ToUrlify(string str)
        {
            if(str==null || str.Length==0)
            {
                return String.Empty;
            }
            char[] str1_char = str.ToCharArray();

            // to save the last non-space character in the string.
            int charIndex = 0;

            // find the index of last character of the string.
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    charIndex = i;
                    break;
                }
            }

            for (int i = str.Length - 1; i >= 0 || charIndex >= 0;)
            {
                // if the space in the end of the input string is less or more then required
                // it will be considered as invalid input string.
                if (charIndex < 0 || i < 0)
                {
                    return "INVALID INPUT";
                }

                if (str[charIndex] == ' ')
                {
                    str1_char[i] = '0';
                    str1_char[i - 1] = '2';
                    str1_char[i - 2] = '%';
                    charIndex--;
                    i = i - 3;
                }
                else
                {
                    str1_char[i] = str[charIndex];
                    charIndex--;
                    i--;
                }
            }
            return new string(str1_char).ToString();
        }
        //With the below method out was not correctly displayed
        public static string Urlify2(char[] input, int len)
        {
            int currSpaces = input.Length - len;
            int currIndex = len - 1;
            while (currIndex > 0)
            {
                while (input[currIndex] != ' ')
                {
                    input[currIndex + currSpaces] = input[currIndex];
                    currIndex--;
                }

                input[currIndex + currSpaces] = '0';
                currSpaces--;
                input[currIndex + currSpaces] = '2';
                currSpaces--;
                input[currIndex + currSpaces] = '%';
                currIndex--;

                if (currSpaces <= 0)
                    break;
            }
            return new string(input);
        }
    }
}
