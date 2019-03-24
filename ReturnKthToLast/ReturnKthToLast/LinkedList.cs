using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnKthToLast
{
    public class LinkedList
    {
        Node head;
        public void Insert(int x)
        {
            if (head == null)
            {
                head.val = x;
                head.next = null;
                return;
            }
            else
            {
                Node newnode = new Node();
                newnode.val = x;
                newnode.next = head;
                head = newnode;
            }
        }
        public int PrintKthToLast(int k)
        {
            if (head == null)
            {
                return 0;
            }
            Node p = new Node();
            Node f = new Node();

            p = head;
            f = head;
            int count = 0;
            while (count != k - 1)
            {
                f = f.next;
                count++;
            }
            while (f.next != null)
            {
                f = f.next;
                p = p.next;
            }
            return p.val;
        }
    }
}
