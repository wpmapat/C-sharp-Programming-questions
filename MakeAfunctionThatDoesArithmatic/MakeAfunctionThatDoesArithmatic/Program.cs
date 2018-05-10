using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAfunctionThatDoesArithmatic
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=8, b = 2;
            string op = "divide";
            double result = Arithmetic(a, b, op);
        }
        public static double Arithmetic(double a, double b, string op)
        {
            if(a<0 && b<0)
            {
                return 0;
            }
            string str = op;
            double result = 0;
            switch(op)
            {
                case "add":
                    result = a + b;
                    Console.WriteLine(result);
                    break;
                case "subtract":
                    result = a - b;
                    Console.WriteLine(result);
                    break;
                case "multiply":
                    result = a * b;
                    Console.WriteLine(result);
                    break;
                case "divide":
                    result = a / b;
                    Console.WriteLine(result);
                    break;
            }
            return result;
        }
    }
}
