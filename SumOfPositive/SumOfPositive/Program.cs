using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,-2,3,4,5};
            int result = 0;
            result = PositiveSum(arr1);
            Console.WriteLine(result);
        }
        public static int PositiveSum(int[] arr)
        {
            int sum = 0;
            for (int i=0;i<arr.Length;i++)
            {
                if(arr[i]>0)
                {
                    sum = sum + arr[i];
                }
            }
            return sum;
        }
    }
}
