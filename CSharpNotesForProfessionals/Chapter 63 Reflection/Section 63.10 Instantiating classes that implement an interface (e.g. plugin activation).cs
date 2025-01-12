using PluginContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_63_Reflection
{
    public class Section_63_10
    {
        public Section_63_10()
        {
            string domainDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Scanning plugins in: {domainDirectory}");

           var pluginList = InstantiatePlugins(domainDirectory);

            if (!pluginList.Any())
            {
                Console.WriteLine("No plugins found in the directory!");
                return;
            }

            foreach (var plugin in pluginList)
            {
                plugin.DoWork();    
            }
        }

        public static IEnumerable<IPlugin> InstantiatePlugins(string directory)
        {
            var pluginAssemblyNames = Directory.GetFiles(directory, "*.dll").Select(name => new
FileInfo(name).FullName).ToArray();
            foreach (var fileName in pluginAssemblyNames)
                AppDomain.CurrentDomain.Load(File.ReadAllBytes(fileName));
            var assemblies = pluginAssemblyNames.Select(System.Reflection.Assembly.LoadFile);
            var typesInAssembly = assemblies.SelectMany(asm => asm.GetTypes());
            var pluginTypes = typesInAssembly.Where(type => typeof(IPlugin).IsAssignableFrom(type));
            return pluginTypes.Select(Activator.CreateInstance).Cast<IPlugin>();
        }
    }
}
