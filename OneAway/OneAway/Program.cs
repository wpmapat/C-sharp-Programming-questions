using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAway
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "pale";
            string str2 = "bae";
            bool result=ToCheck(str1, str2);
            Console.WriteLine(result);
        }
        public static bool ToCheck(string str1, string str2)
        {
            if(str1.Length==0 || str2.Length==0)
            {
                return false;
            }
            if(str1.Length==str2.Length)
            {
                return OneEditReplace(str1, str2);
            }
            if(str1.Length+1==str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            if(str1.Length-1==str2.Length)
            {
                return OneEditInsert(str1, str2);
            }
            return true;
        }

        //Check if you can insert a char ino str1 to make str2
        private static bool OneEditInsert(string str1, string str2)
        {
            int index1 = 0;
            int index2 = 0;
            while(index2<str2.Length && index1<str1.Length)
            {
                if(str1[index1]!=str2[index2])
                {
                    if(index1!=index2)
                    {
                        return false;
                    }
                    index2++;
                }
                else
                {
                    index1++;
                    index2++;
                }
            }
            return true;
        }

        private static bool OneEditReplace(string str1, string str2)
        {
            bool foundDiffrence = false;
            for(int i=0;i<str1.Length;i++)
            {
                if(str1[i]!=str2[i])
                {
                    if(foundDiffrence)
                    {
                        return false;
                    }
                    foundDiffrence = true;
                }
            }
            return true;
        }
    }
}
