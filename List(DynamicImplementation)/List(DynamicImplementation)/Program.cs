using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_DynamicImplementation_
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.PrintList();
            list.Find(2);
            list.Remove(2);
            list.PrintList();
            list.ToFindCount();
        }
        
    }
}
