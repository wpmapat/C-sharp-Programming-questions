using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =11;
            String str1 = ToPrint(n);
            Console.WriteLine(str1);
        }
        public static string ToPrint(int n)
        {
            StringBuilder str = new StringBuilder();
            string st="";
            if (n <= 0 || n % 2 == 0)
            {
                Console.WriteLine("Please enter any odd number.");
                return null;
            }
            else
            {
                for(int i=1;i<=n;i=i+2)
                {
                    st = GetStringWithStars(i,n);
                    str.AppendLine(st);
                }
                for(int j=n-2;j>0;j=j-2)
                {
                    st = GetStringWithStars(j,n);
                    str.AppendLine(st);
                }
            }
            return str.ToString();
            
        }
        //helper function
        public static string GetStringWithStars(int numstars, int maxstars)
        {
            string str = "";
            int cntofspaces = (maxstars - numstars) / 2;
            for(int i=0;i<cntofspaces;i++)
            {
                str = str + ' ';
            }
            for (int i=0;i<numstars;i++)
            {
                str = str + '*';
            }
            return str;
        }
        
    }
}
