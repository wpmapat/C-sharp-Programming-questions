using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheElementThatAppearOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1,1,3,3,4,5,5,7,7,8,8 };
            int high = max(arr1);
            int low = min(arr1);
            int result = ToFindUniqueInteger(arr1, low, high);
            Console.WriteLine(result);
        }
        public static int max(int[] arr1)
        {
            int max = arr1[0];
            for(int i=0;i<arr1.Length;i++)
            {
                if(max>arr1[i])
                {
                    max = arr1[1];
                }
            }
            return max;
        }
        public static int min(int []arr1)
        {
            int min = 0;
            for(int i=0;i<arr1.Length;i++)
            {
                if (min < arr1[i])
                {
                    min = arr1[i];
                }
            }
            return min;
        }
        public static int ToFindUniqueInteger(int []arr1,int low,int high)
        {
            if(low>high)
            {
                return 0;
            }
            if(low==high)
            {
                return low;
            }
            // Find the middle point
            int mid = (low + high) / 2;

            // If mid is even and element next to mid is
            // same as mid, then output element lies on
            // right side, else on left side
            if (mid % 2 == 0)
            {
                if (arr1[mid] == arr1[mid + 1])
                   ToFindUniqueInteger(arr1, mid + 2, high);
                else
                    ToFindUniqueInteger(arr1, low, mid);
            }
            // If mid is odd
            else if (mid % 2 == 1)
            {
                if (arr1[mid] == arr1[mid - 1])
                    ToFindUniqueInteger(arr1, mid + 1, high);
                else
                    ToFindUniqueInteger(arr1, low, mid - 1);
            }
            return 
        }
    }
}
