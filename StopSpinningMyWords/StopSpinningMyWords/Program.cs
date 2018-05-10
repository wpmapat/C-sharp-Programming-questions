using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopSpinningMyWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "You are almost to the last test";
            string result = SpinWords(str);
            Console.WriteLine(result);
        }
        public static string SpinWords(string sentence)
        {
            List<string> ilist = new List<string>();
            string []words=sentence.Split(' ');
            for(int i=0;i<words.Length;i++)
            {
                //string result = (words[i].Length >= 5) ? ToReverseString(words[i]) : words[i];
                //ilist.Add(result);
                if (words[i].Length>=5)
                {
                    string result = ToReverseString(words[i]);
                    ilist.Add(result);
                }
                else
                {
                    ilist.Add(words[i]);
                }
            }
           return string.Join(" ", ilist);

        }
        public static string ToReverseString(string word)
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
