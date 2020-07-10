using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl.Exceptions
{
    public class LogPluginException : Exception
    {
        public LogPluginException(string message) : base(message) { }
    }
}
