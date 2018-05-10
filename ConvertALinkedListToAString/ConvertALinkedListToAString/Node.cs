using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertALinkedListToAString
{
    public class Node
    {
        public int Data
        {
            get;
            private set;
        }
        public Node Next
        {
            get;
            private set;
        }
        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}
