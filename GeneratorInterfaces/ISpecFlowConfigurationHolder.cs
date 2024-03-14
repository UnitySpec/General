using UnitySpec.General.Configuration;

namespace UnitySpec.General.GeneratorInterfaces
{
    public interface ISpecFlowConfigurationHolder
    {
        ConfigSource ConfigSource { get; }
        string Content { get; }
        bool HasConfiguration { get; }
    }
}