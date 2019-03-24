using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroMatrix
{
    //Question-Write an algorithm such that if an element is n m*n matrix is 0, its entire row and column are set to 0.
    //Input-2d matrix
    //output-matrix which has been tranformed
    //Constraint-
    //Edge cases- An empty array, all 0's, all 1's.

    //TimeComplexity=o(m*n)
    //Spaceomplexity=o(n)
    class Program
    {
        const int noOfRows = 3;
        const int noOfCols = 3;
        static void Main(string[] args)
        {
            //3d array
            int[,] a = new int[,]
            {{1,1,1 },
            { 1,0,1 },
            { 1,1,1}
            };
            SetZeroes(a);
            Print(a);
        }

        public static void SetZeroes(int[,] matrix)
        {
            if (matrix == null || matrix.Length == 0) return;
            HashSet<int> rowhash = new HashSet<int>();
            HashSet<int> colhash = new HashSet<int>();
            
            //Added index of row and col in hashset
            for(int i=0;i<matrix.Length;i++)
            {
                for(int j=0;j<matrix.GetLength(0);j++)
                {
                    if(matrix[i,j]==0)
                    {
                        rowhash.Add(i);
                        colhash.Add(j);
                    }
                }
            }

            //setting the same matrix
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if(rowhash.Contains(i) || colhash.Contains(j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

        }
        public static void Print(int[,]arr)
        {
            for(int i=0;i<noOfRows;i++)
            {
                for(int j=0;j<noOfCols;j++)
                {
                    Console.WriteLine(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
        

    
            