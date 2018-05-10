using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStringExpansion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "k(a3(b(a2(c))))"; // "3(b(2(c)))";
            string result = ToExpandString(str);
            Console.WriteLine(result);
        }
        public static string ToExpandString(string str)
        {
            Stack<char> elements = new Stack<char>();
            char ch;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ')')
                {
                    StringBuilder strbuilder = new StringBuilder();
                    while (true)
                    {
                        ch = elements.Pop();
                        if (ch == '(')
                        {
                            break;
                        }
                        strbuilder.Append(ch);
                    }
                    ch = elements.Pop();
                    int digit = ch - '0';
                    if(digit<1 || digit>9)
                    {
                        strbuilder.Append(ch);
                        digit = 1;
                    }
                    string reversedstring = ToReverse(strbuilder.ToString());
                    string result = MakeString(digit, reversedstring);
                    char[] char1 = result.ToCharArray();
                    for (int j = 0; j < char1.Length; j++)
                    {
                        elements.Push(char1[j]);
                    }
                }
                else
                {
                    elements.Push(str[i]);
                }
            }
            return FinalStackContent(elements);
        }
        public static string MakeString(int digit,string contents)
        {
            StringBuilder str1 = new StringBuilder();
            for (int k=0;k<digit;k++)
            {
                str1.Append(contents);
            }
            return str1.ToString();
        }
        public static string ToReverse(string str)
        {
            string reversestring = "";
            int Length;
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reversestring = reversestring + str[Length];
                Length--;
            }
            return reversestring;

        }
        public static string FinalStackContent(Stack<char> elements)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            while(elements.Count!=0)
            {
                ch=elements.Pop();
                builder.Append(ch);
            }
            string result=ToReverse( builder.ToString());
            return result;
        }
    }
}
