using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class MinComparer : IComparer<Min>
    {
        public int Compare(Min x, Min y)
        {
             if(x.Value>y.Value)
            {
                return -1;
            }
             if(x.Value<y.Value)
            {
                return 1;
            }
            return 0;
        }
    }
}
