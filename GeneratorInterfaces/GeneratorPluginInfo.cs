namespace UnitySpec.General.GeneratorInterfaces
{
    public class GeneratorPluginInfo
    {
        public GeneratorPluginInfo(string pathToGeneratorPluginAssembly)
        {
            PathToGeneratorPluginAssembly = pathToGeneratorPluginAssembly;
        }

        public string PathToGeneratorPluginAssembly { get; }
    }
}
