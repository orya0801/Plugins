using System;
using ds.test.impl;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Получаем строковый массив всех имен плагинов
            string[] pluginNames = Plugins.GetPluginNames;
            
            for(int i = 0; i < pluginNames.Length; i++)
            {
                // Получаем плагин с определенный именем
                var plugin = Plugins.GetPlugin(pluginNames[i]);
                // Выводим в консоль описание и результат метода Run 
                // для каждого плагина
                Console.WriteLine(plugin.Description);
                Console.WriteLine(plugin.Run(2, 2));
            }

            try
            {
                // Пытаемся получить несуществующий плагин
                var plugin = Plugins.GetPlugin("qwe");
                Console.WriteLine(plugin.Description);
            }
            catch(NullPluginException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
