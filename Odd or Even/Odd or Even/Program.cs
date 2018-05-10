using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {0,1,2};
            string result = OddOrEven(array);
            Console.WriteLine("The sum of array is {0}", result);
        }
        public static string OddOrEven(int [] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            int sum = 0;
            string result = null;
            if(array.Length==0)
            {
                return result = "even";
            }
            //if the string is empty or contains an array with 0 element.
            if((array.Length==1)&&(array[0]==0))
            {
                return result = "even";
            }
            for(int i=0;i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            if (sum % 2 == 0)
            {
                result = "even";
            }
            else
                result = "odd";
            return result;
        }
    }
}
