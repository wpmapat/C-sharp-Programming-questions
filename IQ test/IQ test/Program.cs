using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQ_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = ("43 28 1 91");
            //string numbers2 = "3,5,2,9,11";
            int result = Test(numbers);
            Console.WriteLine(result);
        }
        public static int Test(string numbers)
        {

            string[] arrnum = numbers.Split(' ');
            int convertedInt = Convert.ToInt32(arrnum[0]);
            int convertedInt1 = Convert.ToInt32(arrnum[1]);
            //to find if the given string has more evenness or oddness
            bool result1 = ToFindEven(convertedInt);
            bool result2 = ToFindEven(convertedInt1);
            
            //if first and second variable in the string are even or odd
            if (result1==result2)
            {
                for(int i=2;i<arrnum.Length;i++)
                {
                    int convertedInti = Convert.ToInt32(arrnum[i]);
                    bool result3 = ToFindEven(convertedInti);
                    if(result3!=result1)
                    {
                        return i + 1;
                    }
                    
                }
            }
            else
            {
                int convertedInt2 = Convert.ToInt32(arrnum[2]);
                bool result3 = ToFindEven(convertedInt2);
                if (result1 != result3)
                {
                    return 1;
                }
                else
                    return 2;
            }


            /*int numodds = 0;
            int numevens = 0;
            int position = 0;
            string[] arraynum = numbers.Split(' ');
            for (int i = 0; i < arraynum.Length; i++)
            {
                bool result = ToFindEven(arraynum[i]);
                if (result == true)
                {
                    numevens = numevens+1;
                }
                else
                {
                    numodds = numodds + 1;
                }
            }
            if (numevens > numodds)
            {
                for (int i = 0; i < arraynum.Length; i++)
                {
                    if (arraynum[i] % 2 != 0)
                    {
                        position = i++;
                    }
                }
            }
            else
            {
                if (numodds > numevens)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] % 2 == 0)
                        {
                            position = i++;
                        }
                    }
                }
            }
            return position;*/
            return 0;
        }
            public static bool ToFindEven(int number)
            {
                if (number % 2 == 0)
                {
                    return true; 
                }
                return false;
            }
        }
    }








                   