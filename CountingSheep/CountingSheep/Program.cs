using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSheep
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] sheeps = { true,  true,  true,  false,
                            true,  true,  true,  true ,
                            true,  false, true,  false,
                            true,  false, false, true ,
                            true,  true,  true,  true ,
                            false, false, true,  true };
            int result = CountSheeps(sheeps);
            Console.WriteLine(result);
        }
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;
            for (int i=0;i<sheeps.Length;i++)
            {
                if(sheeps[i]==true)
                {
                    count++;
                }
            }
            return count;
        }

        public static int CountSheeps2(bool[] sheeps)
        {
            return sheeps.Where(x => (x == true)).Count();
        }
    }
}
