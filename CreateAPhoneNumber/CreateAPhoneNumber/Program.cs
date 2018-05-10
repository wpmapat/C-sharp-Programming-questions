using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers={1,2,3,4,5,6,7,8,9,0 };
            string result=CreatePhoneNumber(numbers);
            Console.WriteLine(result);
        }
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder st = new StringBuilder();
            //Solution with AppendFormat function of StringBuilder
            st.AppendFormat("(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9], numbers);

            //Solution with Append function of StringBuilder
            /*st.Append("(");
            st.Append(numbers[0]);
            st.Append(numbers[1]);
            st.Append(numbers[2]);
            st.Append(") ");
            st.Append(numbers[3]);
            st.Append(numbers[4]);
            st.Append(numbers[5]);
            st.Append("-");
            st.Append(numbers[6]);
            st.Append(numbers[7]);
            st.Append(numbers[8]);
            st.Append(numbers[9]);*/
            //st.AppendFormat()-check for AppendFormat function of SB.

            return st.ToString();
            //Third solution 
            //return  "(" + numbers[0] + numbers[1] + numbers[2] + ") " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];  
        }
    }
}
