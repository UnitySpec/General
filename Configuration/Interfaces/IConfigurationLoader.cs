using UnitySpec.General.GeneratorInterfaces;
using UnitySpec.General.Tracing;

namespace UnitySpec.General.Configuration
{
    public interface IConfigurationLoader
    {
        SpecFlowConfiguration Load(SpecFlowConfiguration specFlowConfiguration, ISpecFlowConfigurationHolder specFlowConfigurationHolder);

        SpecFlowConfiguration Load(SpecFlowConfiguration specFlowConfiguration);

        SpecFlowConfiguration Update(SpecFlowConfiguration specFlowConfiguration, ConfigurationSectionHandler specFlowConfigSection);

        void TraceConfigSource(ITraceListener traceListener, SpecFlowConfiguration specFlowConfiguration);
    }
}
