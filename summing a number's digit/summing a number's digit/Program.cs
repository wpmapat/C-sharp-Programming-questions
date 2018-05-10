using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summing_a_number_s_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = -32;
            int result = SumDigits(number);
            Console.WriteLine(result);
        }
        public static int SumDigits(int number)
        {
            int result = 0;
            if (number < 0)
            {
                number = Math.Abs(number);
            }
            while (number != 0)
            {
                int num1 = number % 10;
                result = result + num1;
                number = number / 10;
            }

            return result;
        }

    }
}
