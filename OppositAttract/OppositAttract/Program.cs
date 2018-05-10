using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppositAttract
{
    class Program
    {
        static void Main(string[] args)
        {
            int flower1 = 0, flower2 = 1;
            bool result = lovefunc(flower1,flower2);
            Console.WriteLine(result);
        }
        public static bool lovefunc(int flower1, int flower2)
        {
            if((flower1%2==0 && flower2%2!=0)||(flower1%2!=0 && flower2%2==0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
