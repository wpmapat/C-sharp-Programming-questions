using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class IntervalComparer : IComparer<Interval>
    {
        public int Compare(Interval x, Interval y)
        {
            if(x.start < y.start)
            {
                return -1;
            }
            else if(x.start > y.start)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
