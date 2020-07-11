using System;
using System.Collections.Generic;
using System.Drawing;
using ds.test.impl;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace ds.test.impl.CustomPlugins
{
    class AdditionPlugin : IPlugin
    {
        public string PluginName => "Addition";
        public string Version => "1.0.0";

        public Image Image 
        {
            get
            {
                return Resources.plus_sign;
            }
        }
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
