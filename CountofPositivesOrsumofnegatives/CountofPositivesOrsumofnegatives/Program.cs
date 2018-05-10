using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountofPositivesOrsumofnegatives
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = null;
            int[] result = CountPositivesSumNegatives(array);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static int[] CountPositivesSumNegatives(int []input)
        {
            if (input==null||input.Length == 0)
            {
                return new int[0];
            }
            int count = 0;
            int sum = 0;
            
            int[] array = new int[2];
            for (int i=0; i< input.Length;i++)
            {
                if (input[i]>0)
                {
                    count = count + 1;
                    array[0] = count;
                }
                if(input[i]<0)
                {
                    sum = sum + input[i];
                    array[1] = sum;
                }
            }
            return array;
        }
    }
}
