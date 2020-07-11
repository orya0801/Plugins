using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http.Headers;
using System.Text;

namespace ds.test.impl.CustomPlugins
{
    class SubstractionPlugin : IPlugin
    {
        public string PluginName => "Substraction";

        public string Version => "1.0.0";

        public Image Image
        {
            get
            {
                return Resources.minus_sign;
            }
        }

        public string Description => "Plugin for substraction two numbers: input1 + input2";

        public int Run(int input1, int input2)
        {
            try
            {
                int res = checked(input1 - input2);
                return res;
            }
            catch(OverflowException)
            {
                throw new OverflowException();
            }
        }

        public double Run(double input1, double input2)
        {
            try
            {
                double res = checked(input1 - input2);
                return res;
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
