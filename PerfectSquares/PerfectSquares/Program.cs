using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = NumSquares(12);
            Console.WriteLine(result);
        }
        public static int NumSquares(int n)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int depth = 0;
            while (queue.Count != 0)
            {
                depth++;
                int size = queue.Count();
                for (int i = 0; i < size; i++)
                {
                    int tmp = queue.Dequeue();
                    int sqrt = (int)(Math.Sqrt(tmp));
                    for (int j = sqrt; j >= 1; j--)
                    {
                        int temp = tmp - j * j;
                        if (temp == 0)
                        {
                            return depth;
                        }
                        else
                        {
                            queue.Enqueue(temp);
                        }
                    }
                }
            }
            return 0;
        }
    }
}
