using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithoutHighestAndLowestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers={ 1, 1, 11, 2, 3 };
            int result = Sum(numbers);
            Console.WriteLine(result);
        }
        public static int Sum(int[] numbers)
        {
            if(numbers.Length==0)
            {
                return 0;
            }
            int sum = 0;
            Array.Sort(numbers);
            for(int i=1;i<numbers.Length-1;i++)
            {
                sum = sum + numbers[i];
            }
            return sum;
        }
    }
}
