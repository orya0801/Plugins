using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl.CustomPlugins
{
    class DivisionPlugin : Plugin, IPlugin
    {
        public string PluginName => "Division";

        public string Version => "1.0.0";

        public Image Image
        {
            get
            {
                return Resources.division_sign;
            }
        }

        public string Description => "Plugin to divide two numbers: input1 / input2";

        public int Run(int input1, int input2)
        {
            if (!IsValid(input1, input2))
                throw new DivideByZeroException();
            return input1 / input2;
        }

        public double Run(double input1, double input2)
        {
            if (!IsValid(input1, input2))
                throw new DivideByZeroException();
            return input1 / input2;
        }
    }
}
