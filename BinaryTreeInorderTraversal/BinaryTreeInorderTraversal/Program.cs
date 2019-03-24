using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInorderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            TreeNode root = new TreeNode();
            BinaryTree node = new BinaryTree();
            root = node.Insert(root, 1);
            root = node.Insert(root, 0);
            root = node.Insert(root, 2);
            root = node.Insert(root, 3);
            //root = node.Insert(root, 8);
            //root = node.Insert(root, 12);
            //list=node.InorderTraversal(root);
            node.GetInorderIterative(root);
            //foreach(int number in list )
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
