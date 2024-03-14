using System.Collections.Generic;

namespace UnitySpec.General.Parser
{
    internal interface ISemanticValidator
    {
        List<SemanticParserException> Validate(SpecFlowFeature feature);
    }
}