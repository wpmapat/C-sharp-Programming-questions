using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheMonkeys
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int[] result = MonkeyCount(number);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static int[] MonkeyCount(int n)
        {
            List<int> ilist = new List<int>();
            for (int i = 1; i <=n; i++)
            {
                ilist.Add(i);
            }
            return ilist.ToArray();
        }
    }
}
