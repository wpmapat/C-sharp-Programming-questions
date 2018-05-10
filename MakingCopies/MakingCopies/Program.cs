using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingCopies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>();
            List<int> ilist = new List<int>();
            ilist.Add(1);
            ilist.Add(2);
            ilist.Add(3);
            ilist.Add(4);
            result=Copy

        }
        public static List<T> Copy<T>(List<T> lst)
        {
            lst.ToList();
            List<int> ilist = new List<int>();
            for (int i=0;i<lst.Count;i++)
            {
                ilist.Add (Convert.ToInt32((lst[i])));
            }
            return ilist;
        }
    }
}
