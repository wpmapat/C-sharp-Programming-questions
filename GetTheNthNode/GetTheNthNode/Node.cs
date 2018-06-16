using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTheNthNode
{
    public class Node
    {

        public int Data;
        public Node Next;

        public Node(int data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node GetNth(Node node, int index)
        {
            int count = 0; 
            Node curr = node;
            while (curr != null)
            {
                if (count == index)
                {
                    return curr;
                }
                else
                { 
                    count++;
                    curr = curr.Next;
                }
            }
            return curr;
        }
    }
}


