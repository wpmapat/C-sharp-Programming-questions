using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNumberInNumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);
            ilist.Add(3);
            ilist.Add(4);
            ilist.Add(5);
            ilist.Add(6);
            ilist.Add(7);
            ilist.Add(8);
            ilist.Add(9);

            List<int> ilist2 = new List<int>();
            ilist2.Add(5);
            ilist2.Add(7);
            ilist2.Add(6);
            ilist2.Add(9);
            ilist2.Add(4);
            ilist2.Add(8);
            ilist2.Add(1);
            ilist2.Add(2);
            ilist2.Add(3);
            int result = FindDeletedNumber(ilist, ilist2);
            Console.WriteLine(result);

        }
        public static int FindDeletedNumber(List<int> startingList, List<int> mixedList)
        {
            foreach(int num in startingList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------");
            foreach (int num in mixedList)
            {
               
                Console.WriteLine(num);
            }
            int sum1 = 0;
            int sum2 = 0;
            foreach(int number in startingList)
            {
                sum1 = sum1 + number;
            }
            foreach(int num in mixedList)
            {
                sum2 = sum2 + num;
            }
            int diff = sum1 - sum2;
            return diff;

            /*int[] array1 = startingList.ToArray<int>();
            int[] array2 = mixedList.ToArray<int>();
            int sum1= 0;
            int sum2 = 0;
            for(int i=0;i<array1.Length;i++)
            {
                sum1 = sum1 + array1[i];
            }
            for(int j=0;j<array2.Length;j++)
            {
                sum2 = sum2 + array2[j];
            }
            int diff = sum1 - sum2;
            return diff;*/
        }
    }
}
