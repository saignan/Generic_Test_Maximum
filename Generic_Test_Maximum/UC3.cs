﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Test_Maximum
{
    internal class UC3
    {
        public string maximumValue(string firstvalue, string secondvalue, string thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
            {
                return secondvalue;
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && (thirdvalue.CompareTo(secondvalue) > 0))
            {
                return thirdvalue;
            }
            else
            {
                return " ";
            }

        }
    }
}
