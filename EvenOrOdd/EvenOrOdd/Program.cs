using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string result = EvenOrOdd(number);
            Console.WriteLine(result);
        }
        public static string EvenOrOdd(int number)
        {
            if (number%2==0)
            {
                return "Number is even";
            }
            else
            {
                return "Number is odd";
            }
        }
    }
}
