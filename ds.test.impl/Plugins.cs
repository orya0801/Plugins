using System;
using System.Collections.Generic;
using ds.test.impl.CustomPlugins;
using ds.test.impl.Exceptions;
using System.Linq;
using System.Text;

namespace ds.test.impl
{
    public static class Plugins
    {
        static List<IPlugin> plugins;

        public static int PluginsCount { get => plugins.Count; }
        public static string[] GetPluginNames { get => plugins.Select(x => x.PluginName).ToArray(); }

        static Plugins()
        {
            // Создание всех видов плагинов
            IPlugin addPlugin = new AdditionPlugin();
            IPlugin substractPlugin = new SubstractionPlugin();
            IPlugin multiplicationPlugin = new MultiplicationPlugin();
            IPlugin divPlugin = new DivisionPlugin();
            IPlugin logPlugin = new LogPlugin();

            // Создание списка всех плагинов
            plugins = new List<IPlugin>();
            plugins.Add(addPlugin);
            plugins.Add(substractPlugin);
            plugins.Add(multiplicationPlugin);
            plugins.Add(divPlugin);
            plugins.Add(logPlugin);
        }

        public static IPlugin GetPlugin(string pluginName)
        {
            try 
            { 
                var plugin = plugins.FirstOrDefault(x => x.PluginName == pluginName);
                return plugin;
            }
            catch (NullReferenceException)
            {
                throw new NullPluginException($"Ошибка: Плагина с именем {pluginName} не существует." +
                    $"Вы можете посмотреть имена всех плагинов воспользовавшись функцией Plugins.GetPluginNames");
            }   
        }
    }
}
