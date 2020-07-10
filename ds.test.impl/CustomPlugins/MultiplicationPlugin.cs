using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl.CustomPlugins
{
    class MultiplicationPlugin : IPlugin
    {
        public string PluginName => "Multiplication";

        public string Version => "1.0.0";

        public Image Image => new Bitmap("../../../multiplicate_sign.jpg");

        public string Description => "Plugin for multiplication 2 numbers: input1 * input2";

        public int Run(int input1, int input2)
        {
            try
            {
                int res = checked(input1 * input2);
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
                double res = checked(input1 * input2);
                return res;
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
