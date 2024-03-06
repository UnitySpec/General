using UnityFlow.General.Configuration;

namespace UnityFlow.General.GeneratorInterfaces
{
    public interface ISpecFlowConfigurationHolder
    {
        ConfigSource ConfigSource { get; }
        string Content { get; }
        bool HasConfiguration { get; }
    }
}