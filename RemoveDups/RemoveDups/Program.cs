using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node();
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(5);
            list.Insert(1);
            list.Insert(4);
            list.Print();
            list.RemoveDups(head);
            list.Print();
        }
        
    }
}
