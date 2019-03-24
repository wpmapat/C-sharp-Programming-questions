using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortColors_DutchNationalFlag_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            ToSortColors(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
        }
        public static void ToSortColors(int[] nums)
        {
            Queue<int> queue = new Queue<int>();
            
            int low = 0;
            int high = nums[nums.Length - 1];
            int mid = 0;

            while (mid <= high)
            {
                switch (nums[mid])
                {
                    case 0:
                        Swap(nums, nums[low], nums[mid]);
                        low++;
                        mid++;
                        break;

                    case 1:
                        mid++;
                        break;

                    case 2:
                        Swap(nums, nums[mid], nums[high]);
                        high--;
                        break;

                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
                for (int i = 0; i < nums.Length; i++)
                    {
                        Console.WriteLine(nums[i]);
                    }
            }
            
        }
        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
