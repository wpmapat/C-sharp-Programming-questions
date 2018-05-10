using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListLength
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Start with the empty list */
            LinkedList llist = new LinkedList();
            llist.InsertNewNode(1);
            llist.InsertNewNode(3);
            llist.InsertNewNode(1);
            llist.InsertNewNode(2);
            llist.InsertNewNode(1);

            Console.WriteLine("Count of nodes is " +llist.getCount());
        }

    }
}
