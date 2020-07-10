using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl
{
    abstract class Plugin
    {
        public virtual bool IsValid(int input1, int input2)
        {
            if (input2 == 0)
                return false;
            else return true;
        }

        public virtual bool IsValid(double input1, double input2)
        {
            if (input2 == 0)
                return false;
            else return true;
        }
    }
}
