using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBSTFromUnsortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 13, 16, 6, 10, 2, 4, 21, 18, 20, 3, 5, 17 };

            TreeNode root = new TreeNode();
            root.val = arr1[0];
            root = BuildBST(arr1, root);
            Console.WriteLine(root.val);
        }
        public static TreeNode BuildBST(int[] nums,TreeNode node)
        {
            if (nums.Length == 0)
            {
                return null;
            }
            for(int i=1;i<nums.Length;i++)
            {
                node = Insert(node, nums[i]);
            }
            return node;
            
        }
        public static TreeNode Insert(TreeNode node, int nodeData)
        {
            if (node == null)
            {
                node.val = nodeData;
                return node;
            }
            if(nodeData<node.val)
            {
                node.left = Insert(node, nodeData);
            }
            if(nodeData>node.val)
            {
                node.right = Insert(node, nodeData);
            }
            return node;
        }
    }
}
