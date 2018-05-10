using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheUniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 2 };
            int result = ToFindUniqueNumber1(arr);
            Console.WriteLine(result);

        }
        public static int ToFindUniqueNumber(int []arr)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i=0;i<arr.Length;i++)
            {
                if(dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict.Add(arr[i], 1);
                }
            }
            for(int j=0;j<arr.Length;j++)
            {
                if(dict[arr[j]]==1)
                {
                    return arr[j];
                }
            }
            return 0;
        }
        public static int ToFindUniqueNumber1(IEnumerable<int> numbers)
        {
            int firstvariable = numbers.ElementAt(0);
            int secondvariable = numbers.ElementAt(1);
            if(firstvariable==secondvariable)
            {
                for(int i=2;i<numbers.Count();i++)
                {
                    if(firstvariable!=numbers.ElementAt(i))
                    {
                        return numbers.ElementAt(i);
                    }
                }
            }
            else
            {
                if (firstvariable == numbers.ElementAt(2))
                {
                    return secondvariable;
                }
                else
                    return firstvariable;
            }
            return 0;
        }
    }
}
