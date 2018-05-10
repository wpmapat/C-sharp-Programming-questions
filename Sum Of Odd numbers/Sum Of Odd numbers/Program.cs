using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_Odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = RowSumOddNumbers(1);
            Console.WriteLine(result);
        }
        public static long RowSumOddNumbers(long n)
        {
            long startingpoint = n * (n - 1) + 1;
            long sum = 0;
            for (int i=0;i<n;i=i+1)
            {
                long temp = startingpoint + (i * 2);
                sum = sum+temp;
            }
            return sum;
        }
    }
}
