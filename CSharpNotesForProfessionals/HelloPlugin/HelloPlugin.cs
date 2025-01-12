using PluginContracts;

namespace HelloPlugin
{
    public class HelloPlugin : IPlugin
    {

        public HelloPlugin()
        {
            Console.WriteLine("HelloPlugin v1");
        }
        public string PluginDescription => "Description Plugin v1";

        public void DoWork()
        {
            Console.WriteLine(PluginDescription);
        }
    }
}
