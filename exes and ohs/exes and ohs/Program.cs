using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exes_and_ohs
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "xxOo";
            bool result = XO(str);
            Console.WriteLine(result);
        }
        public static bool XO(string input)
        {
            int count1 = 0, count2 = 0;
            string newstr = input.ToLower();
            for (int i = 0; i < newstr.Length; i++)
            {
                if (newstr[i] == 'x')
                {
                    count1++;
                }
                if (newstr[i] == 'o')
                {
                    count2++;
                }
                
            }
            return (count1 == count2);
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        } 
        public static bool XO2(string input)
        {
            input = input.ToLower();
            return (input.Select(c => c == 'x').Count() == input.Select(c => c == 'o').Count());
        }
    }
}
