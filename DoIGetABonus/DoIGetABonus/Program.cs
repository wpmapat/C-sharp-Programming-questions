using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoIGetABonus
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 67890;
            bool bonus = true;
            string result = bonus_time(salary,bonus);
            Console.WriteLine(result);
        }
        public static string bonus_time(int salary, bool bonus)
        {
            string result = "";
            if (bonus==true)
            {
                salary = salary * 10;
                return result = "$" + salary;
            }
            else
            {
                return result = "$" + salary;
            }
        }
    }
}
