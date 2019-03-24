using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isunique
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "geeks";
            //bool result = IsUniqueCharBySort(str);
            bool result = IsUniqueByDict(str);
            Console.WriteLine(result);
        }
        //time complexity-O(n)
        public static bool IsUniqueCharBySort(string str)
        {
            int[] count = new int[256];
            foreach(char c in str)
            {
                if(++count[c]>1)
                {
                    return false;
                }
            }
            return true;
        }
        //Time Complexity=O(n) with space complexity
        public static bool IsUniqueByDict(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i=0;i<str.Length;i++)
            {
                if(!dict.ContainsKey(str[i]))
                    {
                    dict.Add(str[i], 1);
                }
                else
                {
                    dict[str[i]]+=1;
                }
            }
            for(int i=0;i<dict.Count;i++)
            {
                if(dict[str[i]]>1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
