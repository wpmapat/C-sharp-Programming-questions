using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myheadatthewrongend
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"tails","body","heads"};
            string [] result = FixTheMeerkat1(arr);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static string[] FixTheMeerkat(string[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
        public static string[] FixTheMeerkat1(string[]arr)
        {
            string temp;
            temp = arr[0];
            arr[0] = arr[2];
            arr[2] = temp;
            return arr;

        }
    }
}
