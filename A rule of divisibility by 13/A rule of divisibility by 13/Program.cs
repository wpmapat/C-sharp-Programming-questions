using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_rule_of_divisibility_by_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 987654321;
            long result = Thirt(number);
            Console.WriteLine(result);
        }
        public static long Thirt(long n)
        {
            long result = n;
            long prevresult = 0;
            while (result != prevresult)
            {
                prevresult = result;
                short[] arr = GetV(result);
                result = ToFindSum(arr);
            }
            return result;
        }
        public static short [] GetV(long num)
        {
            List<short> mylist = new List<short>(); 
            while(num>0)
            {
                short num1 = (short)(num % 10);
                mylist.Add(num1);
                num = num / 10;
            }
            return mylist.ToArray();
        }
        public static long ToFindSum(short[] array)
        {
            int[] pattern = {1,10,9,12,3,4 };
            long sum = 0;  
            for (int i = 0; i < array.Length; i++)
            {
                int j = i % pattern.Length;
                sum = sum+ (array[i] * pattern[j]);
            }
            return sum;
        }
    }

    
}
