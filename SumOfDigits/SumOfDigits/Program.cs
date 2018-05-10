using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 16;
            int result = DigitalRoot(n);
            Console.WriteLine(result);
        }
        public static int DigitalRoot(long n)
        {
            long sum=0;
            if (n<0)
            {
                return 0;
            }
            while (n > 0)
            {
                //take each digit from the number by running mod 10 (ones position in base 10 number)
                sum = sum+(n % 10);
                //reduce the number by a factor of 10 to remove the ones position
                n = n / 10;
                //if the num is greater than or equal to 10 recursively call self
            }
            if (sum >= 10)
            {
                return DigitalRoot(sum);
            }
            return Convert.ToInt32(sum);
        }
    }
}
