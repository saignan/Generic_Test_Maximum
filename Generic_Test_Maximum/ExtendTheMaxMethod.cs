using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Test_Maximum
{
    internal class ExtendTheMaxMethod<T> where T:IComparable<T>
    {
        private T[] values;

        public ExtendTheMaxMethod(params T[] values)
        {
            this.values = values;
        }

        public T Maximum()
        {
            if (values.Length == 0)
            {

                return default;
            }
            else if (values.Length == 1)
            {
                return values[0];
            }
            else
            {
                Array.Sort(values);
                return values[values.Length - 1];
            }
        }
    }
}
