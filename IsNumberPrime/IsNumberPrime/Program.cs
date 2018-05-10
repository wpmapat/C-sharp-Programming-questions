using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            bool result = IsPrime3(n);
            Console.WriteLine(result);
        }
        public static bool IsPrime(int n)
        {
           //loop from 2 to n
           for(int i=2;i<n;i++)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        //more efficient method
        //We only really have to go till square root of any number.the first square root of the number is the middle of the common divisors of the number.
        //if we check the first half of the numbers we are prety much don ewith the second half.
        public static bool IsPrime2(int n)
        {
            if(n==2)
            {
                return true;
            }
            if (n%2==0)
            {
                return false;
            }
            for(int i=3;i*i<=n;i+=2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPrime3(int n)
        {
            if(n==2)
            {
                return true;
            }
            if (n<2||n%2==0)
            {
                return false;
            }
            for(int i=3;i<=Math.Sqrt(n);i+=2)
            {
                if(n%i==0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
