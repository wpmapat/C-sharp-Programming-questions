using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormTheMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 5, 9, 7 };
            long result = MinValue(a);
            Console.WriteLine(result);
        }
        public static long MinValue(int[] a)
        {
            List<int> ilist = new List<int>();
            long result = 0;
            int d = 0;
            Array.Sort(a);
            for(int i = 0; i < a.Length; i++)
            {
                bool isInList = ilist.IndexOf(a[i]) != -1;
                if (isInList==false)
                {
                    ilist.Add(a[i]);
                }
            }
            int j = 0;
            while (j <ilist.Count)
            {
                d = d + ilist[j];
                d = d * 10;
                j++;
            }
            return result=(d / 10);
        }

        //public static long MinValue2(int[] arr)
        //{
        //    List<int> sortedDistinctArr = arr.Distinct().OrderBy(number => number);
        //}
    }
}

