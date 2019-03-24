﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignALinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index < 0 || index >= this.count)
            {
                return -1;
            }
            else
            {
                int counter = 0;
                Node curr = head;
                while (counter != (index))
                {
                    curr = curr.next;
                    counter++;
                }
                return curr.val;
            }
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            Node newNode = new Node(val);
            newNode.next = this.head;
            this.head = newNode;
            this.count++;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (this.length == 0)
            {
                addAtHead(val);
                return;
            }
            Node newNode = new Node(val);
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.next = null;
            this.count++;

        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            Node newNode = new Node(val);
            Node temp = head;
            int counter = 0;
            if ((index) == this.count)) 
                { 
                addAtTail(val);
                return;
            
            if (index > this.count)
            {
                return;
            }
            if (index == 0)
            {
                addAtHead(val);
                return;
            }
            while (counter != (index - 1))
            {
                temp = temp.next;
                counter++;
            }
            newNode.next = temp.next;
            temp.next = newNode;
            this.count++;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                return;
            }
            Node curr = head;
            if (index == 0)
            {
                head = curr.next;
            }
            else
            {
                Node current = head;
                Node pre = null;
                int counter = 0;
                while (counter != index)
                {
                    pre = current;
                    current = current.next;
                    counter++;
                }
                pre.next = current.next;
                this.count--;
            }
        }
    }

}
}
