using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteMiddleNode
{
    class Program
    {
        Node head = new Node();
        static void Main(string[] args)
        {

        }
        public static bool DeleteMiddleNode(Node nodetodelete)
        {
            if (nodetodelete==null)
            {
                return false;
            }
            Node nextPtr = new Node();
            nodetodelete.val = nextPtr.val;
            nodetodelete.next = nextPtr.next;
            return true;
        }
    }
}
