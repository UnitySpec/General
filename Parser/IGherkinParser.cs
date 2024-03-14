using Gherkin;
using System.IO;

namespace UnitySpec.General.Parser
{
    public interface IGherkinParser
    {
        SpecFlowDocument Parse(TextReader featureFileReader, SpecFlowDocumentLocation documentLocation);

        IGherkinDialectProvider DialectProvider { get; }
    }
}