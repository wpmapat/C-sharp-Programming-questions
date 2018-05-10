using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithListLength
{
    class LinkedList
    {
        Node head;//head of the LinkedList
        Node lastnode;
                      
        public void InsertNewNode(int new_data)
        {
            Node new_node=new Node(new_data);//head of the LinkedList 

            if (head == null)
            {
                head = new_node;
            }
            else
            {
                lastnode.next = new_node;
            }
            lastnode =new_node;
        }
        /* Returns count of nodes in linked list */
        public int getCount()
        {
            Node temp = head;
            int count = 0;
            while (temp!= null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

    }
}
