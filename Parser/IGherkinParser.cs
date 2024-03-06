using Gherkin;
using System.IO;

namespace UnityFlow.SpecFlow.Parser
{
    public interface IGherkinParser
    {
        SpecFlowDocument Parse(TextReader featureFileReader, SpecFlowDocumentLocation documentLocation);

        IGherkinDialectProvider DialectProvider { get; }
    }
}