using System.Collections.Generic;

namespace UnityFlow.SpecFlow.Parser
{
    internal interface ISemanticValidator
    {
        List<SemanticParserException> Validate(SpecFlowFeature feature);
    }
}