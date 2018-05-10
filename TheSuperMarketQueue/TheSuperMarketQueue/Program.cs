using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSuperMarketQueue
{
    class Program
    {
      
        static void Main(string[] args)
        {
            long result = 0;
            int[] customers = { 16, 4, 19, 8, 20, 11, 12, 7, 10, 6, 12, 2, 11, 9, 6, 7, 15, 20, 18, 3, 18, 1, 20, 5, 9, 7, 15, 17, 8, 8, 9, 7, 17, 19, 19, 7, 18, 14, 11, 14, 9, 17, 17, 14, 17, 14, 6, 12, 5, 8, 19, 16, 1, 8, 17, 15, 4, 15, 20, 13, 16, 16, 19, 2, 17, 6, 5, 12, 11, 19, 9, 2, 10, 5, 15, 2, 4, 7, 8, 16, 2, 4, 12, 1, 9, 13, 6, 10, 2, 4, 4, 4, 15, 18, 18, 13, 18, 15, 17, 11, 9, 14, 1, 7, 19, 18 };
            int n = 4;
            result = QueueTime(customers, n);
            Console.WriteLine(result);
        }
        public static long QueueTime(int[] customers, int n)
        {
            //creating a list of integers to store till count
            List<int> tills = new List<int>();
            int max = 0, min = 0;
            bool areallTillsFull = false;
            long elapsedTime = 0;
            //Inserting '0' at n positions
            for (int i = 0; i < n; i++)
            {
                tills.Add(0);
            }
            //For loop on customers array
            for (int j = 0; j < customers.Length; j++)
            {
                AssignToTills(customers[j], tills);
                areallTillsFull = AreAllTillsFull(tills);
                if(areallTillsFull==true)
                {
                    min = FindMinFromTills(tills);
                    SubtractFromTills(tills, min);
                    elapsedTime = elapsedTime + min;
                }
                
            }
            max = MaxFromTills(tills);
            elapsedTime = elapsedTime + max;
            return elapsedTime;
        }
        public static void AssignToTills(int customer,List<int> tills)
        {
            for(int i=0;i<tills.Count;i++)
            {
                if(tills[i]==0)
                {
                    tills[i] = customer;
                    return;
                }
            }
        }
        public static bool AreAllTillsFull(List<int> tills)
        {
            bool isFull = true;
            for (int i = 0; i < tills.Count; i++)
            {
                if (tills[i] == 0)
                {
                    isFull = false;
                    return isFull; 
                }
            }
            return isFull;
        }
                
        public static int FindMinFromTills(List<int> tills)
        {
            int min = int.MaxValue;
            for(int i=0;i< tills.Count;i++)
            {
                if(tills[i]<min)
                {
                    min = tills[i];
                }
            }
            return min;
        }
        public static void SubtractFromTills(List<int> tills, int min)
        {

            for (int i = 0; i < tills.Count; i++)
            {
                tills[i] = tills[i] - min;
            }
        }
    
        public static int MaxFromTills(List<int> tills)
        {
            int max = int.MinValue;
            for(int i=0;i< tills.Count;i++)
            {
                if(tills[i]>max)
                {
                    max = tills[i];
                }
            }
            return max;
        }
    }
}
