using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaepSort_MaxHeap_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 2, 1, 5, 6, 4 };
            HeapSort(arr1);
            PrintArray(arr1);
        }
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
            Console.Read();
        }
        public static void HeapSort(int []arr)
        {
            int[] result = new int[arr.Length];
            int lastElement = 0;
            BuildMaxHeap(arr);
            lastElement = arr[arr.Length - 1];

            while(lastElement>0)
            {
                Swap(arr, arr[0], lastElement);
                Heapify(arr, arr[0], lastElement);
                lastElement -= 1;
            }
        }
        public static void BuildMaxHeap(int []arr)
        {
            double i = 0;
            i = arr.Length / 2 - 1;
            i = Math.Floor(i);

            // Build a max heap out of
            // all array elements passed in.
            while (i >= 0)
            {
                Heapify(arr, i, arr.Length);
                i -= 1;
            }
        }
        public static void Heapify(int[] arr, double i, int max)
        {
            double index = 0;
            int valueconvert = Convert.ToInt32(index);
            int leftChild;
            while (i < max)
            {
                index = i;

                leftChild = Convert.ToInt32(2 * i + 1);
                int righChild = Convert.ToInt32(leftChild + 1);

                if (leftChild < max && arr[leftChild] > arr[valueconvert])
                {
                    index = leftChild;
                }

                if (righChild < max && arr[righChild] > arr[valueconvert])
                {
                    index = righChild;
                }

                if (valueconvert == i)
                {
                    return;
                }
            }
        }
        public static void Swap(int[]arr,int firstItemIndex,int lastItemIndex)
        {
            var tmp = arr[firstItemIndex];

            // Swap first and last items in the array.
            arr[firstItemIndex] = arr[lastItemIndex];
            arr[lastItemIndex] = tmp;
        }
    }
}
