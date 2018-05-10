using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertANumberToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 67;
            string result = NumberToString(num);
            Console.WriteLine(result+"");
        }
        public static string NumberToString(int num)
        {
            string result = num.ToString();
            return result;
        }
    }
}
