using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingRooms2
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] intervals = { { 0, 30 }, { 5, 10 }, { 15, 20 } };
            int countOfRooms = MinMeetingRooms(intervals);
            Console.WriteLine(countOfRooms);
        }

        private static int MinMeetingRooms(int[,] intervals)
        {
            int rooms = 1;
            //Interval interval = new Interval();
            if (intervals == null)
            {
                throw new ArgumentNullException("Intervals cannot be null");
            }
            if (intervals.Length == 0)
            {
                return 0;
            }
            List<int> startTimes = new List<int>();
            List<int> endTimes = new List<int>();

            /*Create an array with all start times and an array with all end times*/
            foreach (Interval interval in intervals)
            {
                startTimes.Add(interval.start);
                endTimes.Add(interval.end);
            }
            startTimes.Sort();
            endTimes.Sort();
            int i = 1;
            int j = 0;
            while(i<startTimes.Count)
            {
                //No room is available
                if(startTimes[i]<endTimes[j])
                {
                    rooms++;
                }
                else
                {
                    j++;
                }
                i++;
            }
            return rooms;
        }
    }
}

            