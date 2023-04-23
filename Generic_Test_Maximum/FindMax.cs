using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Test_Maximum
{
    internal class FindMax<T> where T:IComparable<T>
    {
        private T[] values;

        public FindMax(params T[] values)
        {
            this.values = values;
        }

        public T Maximum()
        {
            T max = FindMaximum();
            PrintMax(max);
            return max;
        }

        private T FindMaximum()
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
                T max = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    if (values[i].CompareTo(max) > 0)
                    {
                        max = values[i];
                    }
                }
                return max;
            }
        }

        public void PrintMax(T max)
        {
            Console.WriteLine("Maximum value is: " + max);
        }
    }
}
