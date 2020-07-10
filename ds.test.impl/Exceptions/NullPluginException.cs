using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl.Exceptions
{
    public class NullPluginException : Exception
    {
        public NullPluginException(string message) : base(message)
        {           
        }
    }
}
