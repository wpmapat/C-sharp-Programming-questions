using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleCola
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Sheldon","Leonard","Penny","Rajesh","Howard"};
            long n = 7230702951;
            string result = WhoIsNext(names, n);
            Console.WriteLine(result);
        }
        public static string WhoIsNext(string[] names, long n)
        {
            Queue<string> queue = new Queue<string>();
            long count = 0;
            string str = "";
            //Queue with names
            for(int i=0;i<names.Length;i++)
            {
                queue.Enqueue(names[i]);
            }
            while (count!=n)
            {
                count++;
                str=queue.Dequeue();
                queue.Enqueue(str);
                queue.Enqueue(str);
            }
            return str;
        }
    }
}
