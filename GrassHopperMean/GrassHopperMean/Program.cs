using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrassHopperMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0 };
            int result = FindAverage(num);
            Console.WriteLine(result);
        }
        public static int FindAverage(int[] nums)
        {
            int sum = 0, length = nums.Length;
            for (int i=0;i<nums.Length;i++)
            {
                sum = sum + nums[i];
            }
            int average = sum /length;
            return average;
        }
    }
}
