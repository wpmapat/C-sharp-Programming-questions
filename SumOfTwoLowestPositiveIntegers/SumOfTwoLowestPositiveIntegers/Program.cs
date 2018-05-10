using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoLowestPositiveIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 12, 13, 1, 10, 34, 1 };
            int result=SumOfTwoLowestPositiveIntegers(arr1);
            Console.WriteLine(result);
        }
        public static int SumOfTwoLowestPositiveIntegers(int[] arr1)
        {
            int first, second, arr_size = arr1.Length;
            /* There should be atleast two elements */
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return 0;
            }
            first = second = int.MaxValue;
            for (int i = 0; i < arr_size; i++)
            {
                /* If current element is smaller than first
                then update both first and second */
                if (arr1[i] < first)
                {
                    second = first;
                    first = arr1[i];
                }

                /* If arr[i] is in between first and second
                then update second */
                else
                {
                    if (arr1[i] < second && arr1[i] != first)
                    {
                        second = arr1[i];
                    }
                }
                
            }
            int sum = first + second;
            return sum;
        }
    }
}
