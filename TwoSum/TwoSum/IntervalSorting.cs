using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class IntervalSorting
    {
        public void SortIntervals()
        {
            Interval interval1 = new Interval(7, 10);
            Interval interval2 = new Interval(2, 5);
            Interval interval3 = new Interval(1, 3);

            List<Interval> intervals = new List<Interval>();
            intervals.Add(interval1);
            intervals.Add(interval2);
            intervals.Add(interval3);

            IntervalComparer comparer = new IntervalComparer();
            intervals.Sort(comparer);
        }
    }
}
