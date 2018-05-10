using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_array_by_string_length
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = { "Longer", "Longest", "Short" };
            
            string [] result = SortByLength(array);
            for(int i=0;i<result.Length;i++)
            {
                Console.WriteLine(result[i]+" ");
            }
        }
        public static string [] SortByLength(string [] array)
        {
            //List<string> l = new List<string>(array);

            IEnumerable<string> sortedList = array.OrderBy(str => str.Length);
            return sortedList.ToArray();

            //IEnumerable<string> sortAscendingQuery =
            //from str in l
            //orderby str.Length //"ascending" is default
            //select str;

            //return sortAscendingQuery.ToArray();
        }
    }
}
