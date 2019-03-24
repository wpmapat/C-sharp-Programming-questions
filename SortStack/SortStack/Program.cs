using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(9);
            stack.Push(2);
            stack.Push(8);
            stack.Push(4);
            SortStack(stack);
            foreach(int elements in stack)
            {
                Console.WriteLine(elements);
            }
        }
        public static void SortStack(Stack<int>stack)
        {
            Stack<int> stack1 = new Stack<int>();
            while(stack.Count!=0)
            {
                int curr = stack.Pop();
                
                while (stack1.Count != 0 && curr< stack1.Peek())
                {
                    stack.Push(stack1.Pop());
                }
                stack1.Push(curr);
            }
            while(stack1.Count!=0)
            {
                stack.Push(stack1.Pop());
            }
        }
    }
}
