using System;
using System.Collections.Generic;

namespace UnityFlow.SpecFlow.GeneratorInterfaces
{
    /// IMPORTANT
    /// This class is used for interop with the Visual Studio Extension
    /// DO NOT REMOVE OR RENAME FIELDS!
    /// This breaks binary serialization across AppDomains
    public interface ITestGeneratorFactory
    {
        Version GetGeneratorVersion();
        ITestGenerator CreateGenerator(ProjectSettings projectSettings, IEnumerable<GeneratorPluginInfo> generatorPlugins);
    }
}
