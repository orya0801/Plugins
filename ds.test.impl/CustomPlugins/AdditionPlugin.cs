using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ds.test.impl.CustomPlugins
{
    class AdditionPlugin : IPlugin
    {
        public string PluginName => "Addition";
        public string Version => "1.0.0";
        public Image Image => new Bitmap(@"..\..\..\img\plus_sign.jpg");
        public string Description => "Plugin to sum up two numbers: input1 + input2";
        public int Run(int input1, int input2)
        {
            try
            {
                int res = checked(input1 + input2);
                return res;
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
        public double Run(double input1, double input2)
        {
            try
            {
                double res = checked(input1 + input2);
                return res;
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }
    }
}
