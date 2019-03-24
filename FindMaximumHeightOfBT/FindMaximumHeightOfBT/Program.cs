using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumHeightOfBT
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode();
            BinaryTree node = new BinaryTree();
            root = node.Insert(root, 1);
            root = node.Insert(root, 0);
            root = node.Insert(root, 2);
            root = node.Insert(root, 3);
            int maxHeight = node.ToFindHeight(root);
            Console.WriteLine(maxHeight);
        }
    }
}
