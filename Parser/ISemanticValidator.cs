using System.Collections.Generic;

namespace UnityFlow.General.Parser
{
    internal interface ISemanticValidator
    {
        List<SemanticParserException> Validate(SpecFlowFeature feature);
    }
}