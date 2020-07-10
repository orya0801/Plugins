using System;
using System.Collections.Generic;
using ds.test.impl.Exceptions;
using System.Drawing;
using System.Text;

namespace ds.test.impl.CustomPlugins
{
    class LogPlugin : Plugin, IPlugin
    {
        public string PluginName => "Log";

        public string Version => "1.0.0";

        public Image Image => new Bitmap(@"..\..\..\img\log_sign.jpg");

        public string Description => "Plugin for math operation: log_<input1>_(<input2>)";

        public int Run(int input1, int input2)
        {
            if (!IsValid(input1, input2))
                throw new LogPluginException("Check the input for " +
                    "the following conditions: input1 > 0 ; input1 != 1, input2 > 0");

            try
            {
                double res = checked(Math.Log((double)input2, (double)input1));
                return Convert.ToInt32(res);
            }
            catch (OverflowException)
            {
                throw new OverflowException();
            }
        }

        public double Run(double input1, double input2)
        {
            if (!IsValid(input1, input2))
                throw new LogPluginException("Check the input for " +
                    "the following conditions: input1 > 0 ; input1 != 1, input2 > 0");

            try
            {
                double res = checked(Math.Log(input2, input1));
                return res;
            }
            catch(OverflowException)
            {
                throw new OverflowException();
            }
        }

        public override bool IsValid(double input1, double input2)
        {
            if (input1 <= 0 || input1 == 1 || input2 <= 0)
                return false;
            return true;
        }
        public override bool IsValid(int input1, int input2)
        {
            if (input1 <= 0 || input1 == 1 || input2 <= 0)
                return false;
            return true;
        }
    }
}
