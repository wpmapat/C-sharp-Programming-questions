using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_DynamicImplementation_
{
    public class List
    {
        List<int> numbers = new List<int>();

        public void Add(int num)
        {
            if(numbers.Count==0)
            {
                numbers.Add(num);
            }
            if(!numbers.Contains(num))
            {
                numbers.Add(num);
            }
        }
        public void Remove(int num)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                numbers.Remove(num);
                Console.WriteLine("Number has been removed");
            }
        }
        
        public void Find(int num)
        {
            if(numbers.Contains(num))
            {
                Console.WriteLine("Number has been found :{0} ", num);
            }
            else
            {
                Console.WriteLine("Number has not been found");
            }
        }
        public int ToFindCount()
        {
            int result = numbers.Count();
            Console.WriteLine("Total count of the list is {0}", result);
            return result;
        }
        public void PrintList()
        {
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
