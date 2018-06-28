using ReverseaLinkedList;
using System;

namespace Reverse_a_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node
            {
                data = 0,
                next = null
            };
            Node node1 = new Node
            {
                data = 1,
                next = null
            };
            Node node2 = new Node
            {
                data = 2,
                next = null
            };
            Node node3 = new Node
            {
                next = null
            };
            Node node4 = new Node
            {
                data = 3,
                next = null
            };
            head.next = node1;
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = null;
            Node reverse = ReverseALinkedList(head);
            while(reverse!=null)
            {
                Console.WriteLine(reverse.data);
                reverse = reverse.next;
            }
        }
        public static Node ReverseALinkedList(Node head)
        {
            Node prev = null;
            Node curr = head;
            Node next = null;

            while(curr!=null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
//                next = next.next;
            }
            return prev;
    }
    }
}
