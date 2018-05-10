using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheParityOutlier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 160,3,1719,19,11,13,-21 };
            int result = Find(integers);
            Console.WriteLine(result);
        }
        public static int Find(int[] integers)
        {
            bool isfirsteven = IsEven(integers[0]);
            bool issecondeven = IsEven(integers[1]);
            bool isthirdeven = IsEven(integers[2]);
            int result = 0;
            //if first two variables of the array are even
            if (isfirsteven == true && issecondeven == true)
            {
                result = FindFirstOddNumber(integers);
                return result;
            }
            //if first two variables of the array are odd
            if (isfirsteven != true && issecondeven != true)
            {
                result = FindFirstEvenNumber(integers);
                return result;
            }
            //if first variable is even and second variable is odd
            if (isfirsteven == true && issecondeven != true)
            {
                if (isthirdeven == true)//it means integers in array are even
                    return integers[1];
                else//third variable is odd
                    return integers[0];
            }
            //if first variable is odd and second variable is even
            if (isfirsteven != true && issecondeven == true)
            {
                if (isthirdeven != true)
                {
                    return integers[1];//it means integers in an array are odd
                }
                else//third element is even
                    return integers[0];
            }
            Console.WriteLine("The given array does not have any outlier.");
            return -1;
        }
        public static bool IsEven(int num)
        {
            bool result = true;
            if (num%2!=0)
            {
                result = false;
            }
            return result;
        }
        public static int FindFirstEvenNumber(int[] intergers)
        {
            for (int i = 2; i < intergers.Length; i++)
            {
                if (intergers[i] % 2 == 0)
                {
                    return intergers[i];
                }
            }
            return -1;
        }
        public static int FindFirstOddNumber(int [] integers)
        {
            for (int i=2;i<integers.Length;i++)
            {
                if(integers[i]%2!=0)
                {
                    return integers[i];
                }
            }
            return -1;
        }
    }
}
