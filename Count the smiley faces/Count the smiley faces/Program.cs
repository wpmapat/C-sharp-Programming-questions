using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Count_the_smiley_faces
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] smileys = {   "D", "-)",   "; P",  "8~P;",  "-(",   ";~)",  "; P",  "8 - P",  ":~)" };
            int result = CountSmileys(smileys);
            Console.WriteLine("The number of smileys is {0}",result);
        }
        public static int CountSmileys(string[] str)
        {
            int count=0;
            string pattern = @"^[:;][~\-\s]?[D\)]$";
            for(int i=0;i<str.Length;i++)
            {
                Match match = Regex.Match(str[i], pattern);
                if(match.Success)
                {
                    count = count + 1;
                }
            }
                        
                        /*string[] smileys = { ":D", ":~)", ";~D ", ":)", ":-)", ":-D", ";D", ";-D", ";)", ";-)",": D", ": )", "; D", "; )" };
            int count = 0;
            for(int i=0;i<smileys.Length;i++)
            {
                for(int j=0;j<str.Length;j++)
                {
                    if(str[j]==smileys[i])
                    {
                        count = count + 1;
                    }
                }
            }*/
            return count;
        }
        
    }
}
