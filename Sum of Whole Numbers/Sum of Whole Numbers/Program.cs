using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Whole_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = FindSum(2);
            Console.WriteLine(result);
        }
        public static int FindSum(int n)
        {
            int sum = 0;
            if(n<0)
            {
                return Convert.ToInt32(null);
            }
            else
            {
                sum=n*(n + 1) / 2;
                
            }
            return sum;
        }

    }
}
