using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ValidBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            string braces = "[({})](]";
            bool result = ValidBraces(braces);
            Console.WriteLine(result);
        }
        public static bool ValidBraces(String braces)
        {
            char[] ch1 = braces.ToCharArray();

            //Declare a character stack S.
            Stack<char>s1= new Stack<char>();

            //Traverse the string expression.If the current character is an opening bracket(or { or[then push it to stack.
            for (int i = 0; i < ch1.Length; i++)
            {
                if (ch1[i] == '{' || ch1[i] == '(' || ch1[i] == '[')
                {
                    s1.Push(ch1[i]);
                }
                else if (ch1[i] == '}' || ch1[i] == ')' || ch1[i] == ']')
                {
                    if (s1.Count == 0)
                    {
                        return false;
                    }
                    char ch = s1.Pop();
                    bool result = IsPaired(ch, ch1[i]);
                    if(result==false)
                    {
                        return false;
                    }
                }
            }
            //At the end of the traversal, if there is some opening bracket left in stack then the string is “not balanced”. Hence, return false.
            if (s1.Count!=0)
            {
                return false;
            }
            return true;
        }
        public static bool IsPaired(char open,char close )
        {
            if(open=='(' && close==')')
            {
                return true;
            }
            if (open == '[' && close == ']')
            {
                return true;
            }
            if (open == '{' && close == '}')
            {
                return true;
            }
            return false;
        }
    }
}
