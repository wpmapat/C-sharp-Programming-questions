
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance_Bugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 39;
            int result = persistance(num);
            Console.WriteLine(" Multiplication has occured {0} times", result);
        }
        public static int persistance(int num)
        {
            int result = 0;
            int i = 0;
            List<int> mylist = SplitNumber(num);
            int product = toMultiply(mylist);
            if (product < 10)//base condition
                return 1;
            else
            {
                result = persistance(product);
                return result + 1;
            }

        }
        public static int toMultiply(List<int>list1)
        {
            int product = 1;
            for(int i=0;i<list1.Count;i++)
            {
                product = product * list1[i];
            }
            return product;
        }
        public static List<int> SplitNumber(int num)
        {
            List<int> mylist = new List<int>();
            while (num > 0)
            {
                int addnumber = num % 10;
                mylist.Add(addnumber);
                num = num / 10;
            }
            return mylist;
        }

        /// <summary>
        /// Another way to perform digit splitting
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static char[] SplitNumber2(int num)
        {
            string numStr = num.ToString();
            char[] numCharArr = numStr.ToCharArray();
            return numCharArr;
        }

    }
}
