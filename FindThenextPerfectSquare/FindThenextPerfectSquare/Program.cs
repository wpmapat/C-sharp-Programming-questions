using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindThenextPerfectSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 15241383936;
            long result = FindNextSquare(num);
            Console.WriteLine(result);
        }
        public static long FindNextSquare(long num)
        {
            double d = Math.Sqrt(num),nextnumber = 0,product=0 ;
            //to check if its a perfect integer.
            if(d%1==0)
            {
                nextnumber = d + 1;
                product=nextnumber * nextnumber;
            }
            else
            {
                return -1;
            }
            return (long)(product);
        }
    }
}
