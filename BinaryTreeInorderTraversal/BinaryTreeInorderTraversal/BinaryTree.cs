using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInorderTraversal
{
    public class BinaryTree
    {
        public TreeNode root;
        //Function to insert node in a BST(Effectively making in Heap)
        public TreeNode GetNewNode(int data)
        {
            TreeNode newnode = new TreeNode();
            newnode.data = data;
            newnode.left = null;
            newnode.right = null;
            return newnode;
        }

        //To insert new node in BST and return address of root node
        public TreeNode Insert(TreeNode root, int data)
        {
            if (root == null)
            {
                root = GetNewNode(data);
            }
            //If data inserted is lesser we will insert it to the left tree
            else if (data < root.data)
            {
                root.left = Insert(root.left, data);
            }
            //If data inserted is greater we will insert it to the right tree
            else
                root.right = Insert(root.right, data);
            return root;
        }

        //Inorder Traversal
        public List<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new List<int>();
            list = GetInorder(root, list);
            return list;
        }
    public List<int>GetInorder(TreeNode root, List<int>list)
        { 
            if (root==null)
            {
                return new List<int>();
            }
            if(root.left==null && root.right==null)
            {
                list.Add(root.data);
                return list;
            }
            
            InorderTraversal(root.left);
            list.Add(root.data);
            Console.WriteLine(root.data);
            InorderTraversal(root.right);
            return list;
        }
        public void GetInorderIterative(TreeNode tree)
        {
            List<int> result = new List<int>();

            //Create an Empty Stack
            Stack<TreeNode> stack = new Stack<TreeNode>();

            //Start from root node and set curr node to root
            TreeNode curr = root;

            //if curr node is null and stack is also empty then we are done
            while (stack.Count!=0||curr != null)
            {
                //if curr node is not null and stack is also not empty then push it to the stack. And move to its left child
                if(curr!=null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    curr=stack.Pop();
                    Console.WriteLine("{0}", curr.data);
                    curr = curr.right;
                }
            }
        }
    }
}
