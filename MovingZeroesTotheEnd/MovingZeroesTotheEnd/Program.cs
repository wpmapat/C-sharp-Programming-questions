using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZeroesTotheEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            int[] result = MoveZeroes(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static int[] MoveZeroes(int[] arr)
        {
            int count = 0;//to count the non zero elements
            //Traverse the array. If element encountered is non zero, then replace the element at index 'count' with this element.
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }
            //Now all non zero elements are moved to front and count is set as index of first 0. Make all elements 0 from  count to end
            while (count < arr.Length)
            {
                arr[count] = 0;
                count++;
            }
            return arr;
        }
    }
}
