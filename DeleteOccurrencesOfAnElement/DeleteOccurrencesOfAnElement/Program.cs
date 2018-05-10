using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOccurrencesOfAnElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20,37,20,21 };
            int x = 1;
            int[] resultarray = new int[arr.Length];
            resultarray=DeleteNth(arr, x);
            for (int i = 0; i < resultarray.Length; i++)
            {
                Console.WriteLine(resultarray[i]);
            }
        }
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> list = new List<int>();
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //1. create a dictionary from array values
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
                int count = dict[arr[i]];
                if (count <= x)
                {
                    list.Add(arr[i]);
                }
            }
            return list.ToArray();
        }
    }
}
