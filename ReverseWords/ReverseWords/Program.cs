using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring = "seeta aur geeta";
            string result = ReverseWords(inputstring);
            Console.WriteLine(result);
        }
        public static string ReverseWords(string str)
        {
            List<string> ListOfWords = new List<string>();
            string result="";
            string[]words=str.Split(' ');
            for (int i=0;i<words.Length;i++)
            {
                result = ToReverseWords(words[i]);
                ListOfWords.Add(result);
            }
            return string.Join(" ", ListOfWords);
            //Linq code
            //string result = string.Join(" ",str.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            //return result;
        }
        public static string ToReverseWords(string word)
        {
            string reversestring = "";
            int Length;
            Length = word.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + word[Length];
                Length--;
            }
            return reversestring;
        }
    }
}
