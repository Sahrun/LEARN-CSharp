namespace PluginContracts
{
    public interface IPlugin
    {
        string PluginDescription { get; }
        void DoWork();
    }
}
