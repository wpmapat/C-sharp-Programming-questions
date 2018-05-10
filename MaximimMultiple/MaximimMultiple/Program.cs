using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximimMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor = 10;
            int bound = 50;
            int result = MaxMultiple(divisor, bound);
            Console.WriteLine(result);
        }
       public static int MaxMultiple(int divisor, int bound)
        {
            return bound - bound % divisor;
        }
    }
}

