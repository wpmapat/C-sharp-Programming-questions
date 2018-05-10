using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Find_Middle_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] inputArray = {5,10,14};
            int result = ToFindMiddle(inputArray);
            Console.WriteLine(result);
        }
        public static int ToFindMiddle(double[] inputArray)
        {
            if(((inputArray[0]>inputArray[1])&&(inputArray[0]<inputArray[2]))||(inputArray[0]<inputArray[1])&&(inputArray[0]>inputArray[2]))
            {
                return 0;
            }
            if (((inputArray[1] > inputArray[0]) && (inputArray[1] < inputArray[2])) || (inputArray[1] < inputArray[0]) && (inputArray[1] > inputArray[2]))
            {
                return 1;
            }
            else
                return 2;
        }
    }
}
