using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFiltering
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listofitems = new List<object>();
            listofitems.Add(1);
            listofitems.Add(2);
            listofitems.Add("a");
            listofitems.Add("b");
            IEnumerable<int> result = GetIntegersFromList(listofitems);
            foreach(int num in result)
            {
                Console.WriteLine(num);
            }
            for(int i=0;i<result.Count();i++)
            {
                Console.WriteLine(result.ElementAt(i));
            }
        }
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> ilist = new List<int>();
            int value = 0;
            for(int i=0;i<listOfItems.Count;i++)
            {
                string x = listOfItems[i].ToString();
                value=0;
                //the int.TryParse method.If it successfully parses it will return true, and the out result will have its value as an integer.
                if (int.TryParse(x, out value))
                {
                    ilist.Add(value);
                }
            }
            return ilist;
        }
    }
}
