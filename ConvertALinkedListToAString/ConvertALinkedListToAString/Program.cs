using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertALinkedListToAString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Node n5 = new Node(16);
            //Node n4 = new Node(9,n5);
            //Node n3 = new Node(4,n4);
            //Node n2 = new Node(1, n3);
            //Node n1 = new Node();
            string result = Stringify(null);
            Console.WriteLine(result);
        }
        public static string Stringify(Node list)
        {
            List<string> ilist = new List<string>();
            Node curr = list;
            while(curr != null)
            {
                ilist.Add(curr.Data.ToString());
                curr = curr.Next;
            }
            ilist.Add("null");
            return string.Join(" -> ", ilist);
        }
    }
}
