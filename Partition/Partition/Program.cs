using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partition
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public Node Partition(Node head, int k)
        {
            if(head==null)
            {
                return null;
            }
            Node SmallLinkList = new Node();
            Node BigLinkList = new Node();
            Node curr = head;
            Node newnode = new Node();

            while(curr!=null)
            {
                if(curr.val<k)
                {
                    SmallLinkList.val = curr.val;
                    curr = curr.next;
                }
                else
                {
                    BigLinkList.val = curr.val;
                }
            }

        }
    }
}
