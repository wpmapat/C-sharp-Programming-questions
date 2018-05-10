using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSidesOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 3, 2, 1 };
            int result = ToFindEvenIndex(arr);
            Console.WriteLine(result);
        }
        public static int FindEvenIndex(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                int leftsum = 0, rightsum = 0;
                leftsum= FindLeftSideSum(i, arr);

                rightsum = FindRightSideSum(i,arr);
                if(rightsum==leftsum)
                {
                    return i;
                }
            }
            return -1;
        }
        public static int FindLeftSideSum(int i,int[]arr )
        {
            int sum = 0;
            for (int j=0;j<i;j++)
            {
                sum = sum + arr[j];
            }
            return sum;
        }
        public static int FindRightSideSum(int i,int []arr)
        {
            int sum = 0;
            for(int j=i+1;j<arr.Length;j++)
            {
                sum = sum + arr[j];
            }
            return sum;
        }
        //Another way to perform the same job. 
        public static int ToFindEvenIndex(int []arr)
        {
            int totalsum = 0,leftsum=0;
            for(int i=0;i<arr.Length;i++)
            {
                totalsum = totalsum + arr[i];
            }

            for (int j = 0; j< arr.Length; j++)
            {
                leftsum = leftsum + arr[j];
                int rightsum = totalsum - leftsum;
                if(rightsum==leftsum-arr[j])
                {
                    return j;
                }
            }
            return -1;
        }
    }
}
