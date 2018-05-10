using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNDivisibleByXAndY
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 8, x = 3, y = 4;
            bool result = IsDivisible(n,x,y);
            Console.WriteLine(result);
        }
        public static bool IsDivisible(long n, long x, long y)
        {
            if(x==0 && y==0)
            {
                return false;
            }
            if (n%x==0 && n%y==0)
            {
                return true;
            }
            return false;
        }
    }
}
