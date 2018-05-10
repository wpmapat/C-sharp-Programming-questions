using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnesandZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] BinaryArray = { 1, 1, 1, 1 };
            int result = binaryArrayToNumber(BinaryArray);
            Console.WriteLine(result);
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            Array.Reverse(BinaryArray);
            int sum = 0;
            for (int i = 0; i < BinaryArray.Length; i++)
            {
                if (BinaryArray[i] == 1)
                {
                    // Method uses raising 2 to the power of the index. 
                    //if (i == 0)
                    //{
                    //    sum += 1;
                    //}
                    //else
                    //{
                        sum += (int)Math.Pow(2, i);
                    //}
                }

            }
            return sum;
        }
        
    }
}
