using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourOrderPlease
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "is2 Thi1s T4est 3a4of Fo1r pe6ople g3ood th5e the2";
            string result = Order(str);
            Console.WriteLine(result);
        }
        public static string Order(string words)
        {
            if(words==""||words==null)
            {
                return null;
            }
            Console.WriteLine("Input string is: \"" + words + "\"");
            string[] words1 = words.Split(' ');
            int length = words1.Length;
            string[] result = new string[words1.Length];
            for (int i = 0; i < words1.Length; i++)
            {
                int index = FindDigit(words1[i]);
                result[index] = words1[i];
            }
            return string.Join(" ", result);
        }
        public static int FindDigit(string word)
        {
            int result=0;
            
            for(int i=0; i<word.Length;i++)
            {
                if(word[i]<='9' && word[i]>'0')
                {
                    result= word[i] - '0';
                    break;
                }
            }
            return result-1;
        }
    }
}
