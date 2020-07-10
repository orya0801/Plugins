using NUnit.Framework;
using ds.test.impl;
using ds.test.impl.Exceptions;
using System;

namespace NUnitTestForLib
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CountPlugins()
        {
            Assert.AreEqual(5, Plugins.PluginsCount);
        }

        [Test]
        public void CheckPluginNames()
        {
            Assert.AreEqual(new string[] { "Addition", "Substraction", "Multiplication", "Division", "Log"}, Plugins.GetPluginNames);
        }

        [Test]
        public void CheckAdditionalPlugin()
        {
            var plugin = Plugins.GetPlugin("Addition");
            Assert.AreEqual(5, plugin.Run(2, 3));
            Assert.AreEqual(6.1, plugin.Run(2.1, 4));
        }

        [Test]
        public void CheckAdditionalPluginForEx()
        {
            try
            {
                var plugin = Plugins.GetPlugin("Addition");
                plugin.Run(2147483647, 1);
                Assert.Fail("no exception thrown");
            }
            catch(Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
            }
        }

        [Test]
        public void CheckSubstractionPlugin()
        {
            var plugin = Plugins.GetPlugin("Substraction");
            Assert.AreEqual(2, plugin.Run(5, 3));
            Assert.AreEqual(-6.1, plugin.Run(2.9, 9));
        }

        [Test]
        public void CheckSubstractionPluginForEx()
        {
            try
            {
                var plugin = Plugins.GetPlugin("Substraction");
                plugin.Run(-2147483648, 1);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
            }
        }

        [Test]
        public void CheckMultiplicationPlugin()
        {
            var plugin = Plugins.GetPlugin("Multiplication");
            Assert.AreEqual(15, plugin.Run(5, 3));
            Assert.AreEqual(2.1, plugin.Run(0.3, 7));
        }

        [Test]
        public void CheckMultiplicationPluginForEx()
        {
            try
            {
                var plugin = Plugins.GetPlugin("Multiplication");
                plugin.Run(2147483647, 2);
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is OverflowException);
            }
        }

        [Test]
        public void CheckDivisionPlugin()
        {
            var plugin = Plugins.GetPlugin("Division");
            Assert.AreEqual(2, plugin.Run(8, 4));
            Assert.AreEqual(3.2, plugin.Run(6.4, 2));
        }

        [Test]
        public void CheckDivisionPluginForEx()
        {
            try
            {
                var plugin = Plugins.GetPlugin("Division");
                plugin.Run(6, 0);
                Assert.Fail($"no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is DivideByZeroException);
            }
        }

        [Test]
        public void CheckLogPlugin()
        {
            var plugin = Plugins.GetPlugin("Log");
            Assert.AreEqual(5, plugin.Run(2, 32));
        }

        public void CheckLogPluginForEx()
        {
            try
            {
                var plugin = Plugins.GetPlugin("Log");
                plugin.Run(2, -1);
                Assert.Fail($"no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is LogPluginException);
            }
        }
    }
}