using UnityFlow.SpecFlow.Configuration;

namespace UnityFlow.SpecFlow.GeneratorInterfaces
{
    public interface ISpecFlowConfigurationHolder
    {
        ConfigSource ConfigSource { get; }
        string Content { get; }
        bool HasConfiguration { get; }
    }
}