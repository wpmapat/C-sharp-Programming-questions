using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnKthToLast
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList curr = new LinkedList();
            
            curr.Insert(1);
            curr.Insert(2);
            curr.Insert(3);
            curr.Insert(4);
            curr.Insert(5);
            int result = curr.PrintKthToLast(2);
            Console.WriteLine(result);
        }
    }
}
