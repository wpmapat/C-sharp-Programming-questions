using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignALinkedList
{
        public class Node
            {
            readonly private int val;
            readonly private Node next;

            public Node(int x)
            {
                this.val = x;
                next = null;
            }
        }
    
}
