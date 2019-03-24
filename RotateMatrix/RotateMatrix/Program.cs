using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    //Question-Given an image represented by n*n matrix, where each pixel n the image is 4 bytes,
    //write a method to rotate the image by 90 degrees.
    //Can yo do it in place?

    //Input=2d matrix
    //output=rotated matrix by 90 degrees
    //Constraint-in place rotation
    //edge cases- an empty matrix, even and odd value matrix.

    class Program
    {
        const int matrixRows = 2;
        const int matrixCols = 2;
        static void Main(string[] args)
        {
            int[,] arr = new int[matrixRows,matrixCols];
            int count = 0;
            for(int i=0;i<matrixRows;++i)
            {
                for(int j=0;j<matrixCols;++j)
                {
                    arr[i, j] =count++;
                }
            }
            Console.WriteLine("....Orignal Matrix....");
            PrintMatrix(arr);
            int length = arr.Length - 1;
            for(int i=0;i<=(length/2);i++)
            {
                for (int j=0;j<length-i;j++)
                {
                    Swap(arr[i, i], arr[i, length]);
                    Swap(arr[i, i], arr[length, length]);
                    Swap(arr[i, i], arr[length, i]);
                }
                
            }
            Console.WriteLine("....After Rotation....");
            PrintMatrix(arr);

        }
        public static void PrintMatrix(int [,]arr)
        {
            for (int i = 0; i < matrixRows; i++)
            {
                for (int j = 0; j < matrixCols; j++)
                {
                    Console.Write (arr[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
        public static void Swap(int i,int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
    }
}
