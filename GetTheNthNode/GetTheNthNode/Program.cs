using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNthNode
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> ilist = new LinkedList<int>();
            ilist.AddLast(1);
            ilist.AddLast(21);
            ilist.AddLast(13);
            ilist.AddLast(5);
            Node node = new Node(1);
            node.GetNth(node, 2);
            Console.WriteLine(node.Data);
        }

    }
}
