using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrizeDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "Addison,Jayden,Sofia,Michael,Andrew,Lily,Benjamin";
            int[] we = { 4, 2, 1, 4, 3, 1, 2 };
            int n = 4;
            string result = NthRank(st, we, n);
            Console.WriteLine(result);
        }
        public static string NthRank(string st, int[] we, int n)
        {
            if(string.IsNullOrEmpty(st))
            {
                return "No Participants";
            }
            if (n > we.Length)
            {
                return "Not enough Participants";
            }
            
            string []namesArr=st.Split(',');
            Dictionary<string, int> winningnumbersDict = new Dictionary<string, int>(); 
            for(int i= 0;i< namesArr.Length;i++)
            {
                int winningnumber = 0;
                string name = namesArr[i];
                for(int j=0;j<name.Length;j++)
                {
                    winningnumber = winningnumber +FindIntegerValueOfTheChar(name[j]);//assuming this will pass value of each char from the dictionary.for eg:p->16
                }
                winningnumber = (winningnumber + name.Length) * we[i];
                winningnumbersDict.Add(name, winningnumber);
            }
            //IOrderedEnumerable<KeyValuePair<string, int>> sortedWinningNumbers = winningnumbersDict.OrderByDescending(c => c.Value);

            IEnumerable<string> sortedNames = winningnumbersDict
                                                .OrderByDescending(c => c.Value)
                                                .Select(kvp => kvp.Key);

            return sortedNames.ElementAt(n - 1);

            //string winnername = sortedWinningNumbers.ToArray()[n - 1].Key;
            //string winnername = Convert.ToString(from keyValuePair in sortedWinningNumbers where keyValuePair.Value == n select keyValuePair.Key) ;
            //return winnername;
        }
        public static int FindIntegerValueOfTheChar(char ch)
        {
            int ascii = ch;
            int asciiofa = 'a';
            return ascii - asciiofa + 1;
        }
    }
}
