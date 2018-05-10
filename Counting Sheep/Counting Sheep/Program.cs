using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sheep
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean [] Sheeps= {true,true,false,true,true,false};
            int num = CountSheeps(Sheeps);
            Console.WriteLine("The number of Sheeps present are {0}", num);
        }
        public static int CountSheeps(bool [] Sheeps)
        {
            int count = 0;
            int i = 0;
            while(i<Sheeps.Length)
            {
                if (Sheeps[i] == true)
                {
                    count = count + 1;
                    i++;
                }
                else
                     i++;
            }
            return count;
        }
    }
}
