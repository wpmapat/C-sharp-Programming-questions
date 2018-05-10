using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSubClassesAdamandEve
{
    class God
    {
        public static Human[] Create()
        {
            Man Adam = new Man();
            Woman Eva = new Woman();
            Human[] instances= {Adam,Eva};
            return instances;
        }
    }
    
}
