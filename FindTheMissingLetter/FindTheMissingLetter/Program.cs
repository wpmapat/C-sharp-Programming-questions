using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMissingLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = { 'O', 'Q','R','S' };
            FindMissingLetter(array);
        }
        public static char FindMissingLetter(char[] array)
        {
            int[] sequence = new int[array.Length];

            for (int i = 0; i <array.Length-1; i++)
            {
                if(array[i+1]-array[i]>1)
                {
                    char missingchar = Convert.ToChar(array[i] + 1);
                    Console.WriteLine(missingchar);
                    return missingchar;
                }
                sequence[i] = Convert.ToInt32(array[i]);
            }
           /* for (int j = 0; j < sequence.Length; j++)
            {
                if (sequence[j + 1] - sequence[j] > 1)
                {
                    char ch = Convert.ToChar(sequence[j ]+ 1);
                    Console.WriteLine(ch);
                    return ch;
                }
            }*/
           return ' ';
        }
        
    }
}
