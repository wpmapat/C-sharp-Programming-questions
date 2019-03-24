using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToFindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums={ 1,3,4,2,2};
            int result = ToFindDuplicate(nums);
            Console.WriteLine(result);
        }
        public static int ToFindDuplicate(int[]nums)
        {
            if(nums.Length==0)
            {
                return 0;
            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                    dict.Add(nums[i], 1);
            }
            for(int i=0;i<nums.Length;i++)
            {
                if(dict[nums[i]]>1)
                {
                    return nums[i];
                }
            }
            return 0;
        }
    }
}
