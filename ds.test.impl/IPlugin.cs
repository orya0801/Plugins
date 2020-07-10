using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ds.test.impl
{
    public interface IPlugin
    {
        string PluginName { get; }
        string Version { get; }
        Image Image { get; }
        string Description { get; }
        int Run(int input1, int input2);
        double Run(double input1, double input2);

    }
}
