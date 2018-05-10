using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 21445;
            int result = 0;
            result = DescendingOrder(num);
            Console.WriteLine(result);
        }
        public static int DescendingOrder(int num)
        {
            string str = num.ToString();
            IEnumerable<char>sortedarray=str.OrderByDescending(s=>s);
            char[] chArr = str.ToCharArray();
            //IEnumerable<char> sortedarray  =chArr.OrderByDescending(c=>c);
            chArr=sortedarray.ToArray();
            str=new string(chArr);
            int result = int.Parse(str);
            return result;
        }
    }
    
}
