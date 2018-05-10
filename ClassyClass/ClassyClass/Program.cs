using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
            string name = "John";
            int age = 12;
            Person p1 = new Person(name, age);
            //result = p1.InfoGetter();
            result = p1.Info;
            Console.WriteLine(result);
        }
        
    }
}
