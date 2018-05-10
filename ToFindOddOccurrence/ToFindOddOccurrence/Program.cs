using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ToFindOddOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = { 2, 3, 5, 4, 5, 2, 4, 3, 5, 2, 4, 4, 2 };
            int number = find_it(seq);
            Console.WriteLine("The number is {0}",number);
        }
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> ht = new Dictionary<int, int>();

            //putting all elements in Dictionary
            for (int i = 0; i < seq.Length; i++)
            {
                if (ht.ContainsKey(seq[i]))
                {
                    int count = ht[seq[i]];
                    ht[seq[i]] = count + 1;
                }
                else
                    ht.Add(seq[i], 1);
            }

            //for checking odd occurences of an int in Dictionary
            foreach (KeyValuePair<int, int> dt in ht)
            {
                if (dt.Value%2!=0)
                {
                    return dt.Key;
                }
            }
            return 0;
        }
    }
}

