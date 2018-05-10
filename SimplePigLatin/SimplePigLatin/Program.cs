using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimplePigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World !";
            string result = PigIt(str);
            Console.WriteLine(result);
        }
        public static string PigIt(string str)
        {
            //if the string is null or empty
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            string [] words=str.Split(' ');
            for(int i=0;i<words.Length;i++)
            {
                words[i] = RearrangeChars(words[i]);
            }
            return string.Join(" ", words);
        }
        public static bool IsLastLetterPunctuationMark(char c)
        {
            
            if (c=='!')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string RearrangeChars(string str)
        {
            int length = str.Length;
            char firstletter = str[0];
            char lastletter = str[length - 1];
            bool result = IsLastLetterPunctuationMark(lastletter);
            if (result==true)
            {
                //if in word array there is only one element
                if(str.Length==1)
                {
                    return str;
                }
                str = str.Substring(1);
                str = str.Substring(0, str.Length - 1);
                str = str + firstletter + "ay" + lastletter;
            }
            else
            {
                str = str.Substring(1);
                str = str + firstletter + "ay";
            }
            return str;
        }
    }
}
