using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    public class LinkedList
    {
        Node head = new Node();
        //Insert value at the start
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
        public void RemoveDups(Node head)
        {
            if(head==null)
            {
                return;
            }
            Node curr = head;
            Node prev = null;

            Dictionary<int, bool> map = new Dictionary<int,bool>();
           
            while(curr.next!=null)
            {
                if (map.ContainsKey(curr.next.val))
                {
                    map.Add(curr.val, true);
                    curr.next = curr.next.next;
                    prev = curr.next.next;
                }
                else 
                {
                    map.Add(curr.next.val, false);
                    curr = curr.next;
                    prev = prev.next;
                }
            }

        }
        public void Print()
        {
            Node curr = head;
            Console.WriteLine("List is:");
            while (curr != null)
            {
                Console.WriteLine(curr.val);
                curr = curr.next;
            }
        }
    }
}
