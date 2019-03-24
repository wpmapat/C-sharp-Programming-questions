using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumHeightOfBT
{
    public class BinaryTree
    {
        int maxheight = 0;
        public TreeNode root;
        //Function to insert node in a BST(Effectively making in Heap)
        public TreeNode GetNewNode(int data)
        {
            TreeNode newnode = new TreeNode();
            newnode.val = data;
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
            else if (data < root.val)
            {
                root.left = Insert(root.left, data);
            }
            //If data inserted is greater we will insert it to the right tree
            else
                root.right = Insert(root.right, data);
            return root;
        }

        public int ToFindHeight(TreeNode root)
        {
           

            if(root==null)
            {
                return 0;
            }
            int maxLeftHeight = ToFindHeight(root.left);
            int maxRightHeight = ToFindHeight(root.left);
            maxheight = Math.Max(maxLeftHeight, maxRightHeight) + 1;
            return maxheight;
        }

    }
}
