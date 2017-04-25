using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    class Min:IComparable<Min>
    {
        private int _min;
        public Min()
        {
            _min = 0;
        }
        public Min(int val)
        {
            Value = val;
        }
        public int Value
        {
            set
            {
                if (value>=0 && value<=10)
                {
                    _min = value;
                }
            }
            get
            {
                return _min;
            }
        }

        public int CompareTo(Min other)
        {
            if (_min>other.Value)
            {
                return 1;
            }
            if (_min < other.Value)
            {
                return -1;
            }
            return 0;
        }
    }
}
