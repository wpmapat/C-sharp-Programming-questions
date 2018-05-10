using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "apple ban";
            string[] result = AddLength(str);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]);
            }
        }
        public static string[] AddLength(string str)
        {
            List<string> ilist = new List<string>();
            int count = 0;
            string[] splittedarray = str.Split(' ');
            for(int i=0;i<splittedarray.Length;i++)
            {
                count=splittedarray[i].Length;
                ilist.Add(splittedarray[i] +" " + count);
            }
            return ilist.ToArray();
        }
    }
}
