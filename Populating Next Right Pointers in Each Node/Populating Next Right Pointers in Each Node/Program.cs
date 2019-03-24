using System;

namespace Populating_Next_Right_Pointers_in_Each_Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void Connect(TreeLinkNode root)
        {
            TreeLinkNode child = null;
            TreeLinkNode childHead = null;

            //First while loop goes from top to bottom
            while (root != null)
            {
                //Second while loop from right to left
                while (root != null)
                {
                    if (root.left != null)
                    {
                        if (childHead != null)
                        {
                            child.next = root.left;
                        }
                        else
                        {
                            childHead = root.left;
                        }
                        child = root.left;
                    }
                    if (root.right != null)
                    {
                        if (childHead != null)
                        {
                            child.next = root.right;
                        }

                        else
                        {
                            childHead = root.right;
                        }
                        child = root.right;
                    }
                    root = root.next;
                }
                root = childHead;
                childHead = null;
                child = null;
            }
        }
    }
}
