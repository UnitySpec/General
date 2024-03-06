using System;

namespace UnityFlow.SpecFlow.Plugins
{
    [Flags]
    public enum PluginType
    {
        Generator = 1,
        Runtime = 2,
        GeneratorAndRuntime = Generator | Runtime
    }
}