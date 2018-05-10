using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mr.Whiskers";
            Cat cat = new Cat(name);
            string result=cat.Speak();
            Console.WriteLine(result);
        }
    }
}
