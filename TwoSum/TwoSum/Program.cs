using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {2,7,11,15};
            int target = 22;
            
            int[] result = Calculate(arr1, target);

            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static int[] Calculate(int []arr1,int target)
        {
            List<int> list = new List<int>();
            int sum = 0;
            if (arr1.Length==0)
            {
                return arr1;
            }
            for(int i=0;i<arr1.Length-1;i++)
            {
                for(int j=i+1;j<arr1.Length;j++)
                {
                    sum = arr1[i] + arr1[j];
                    if(sum==target)
                    {
                        list.Add(i);
                        list.Add(j);
                        return list.ToArray();
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
