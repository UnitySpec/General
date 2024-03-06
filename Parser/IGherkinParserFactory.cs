using Gherkin;
using System.Globalization;

namespace UnityFlow.SpecFlow.Parser
{
    public interface IGherkinParserFactory
    {
        IGherkinParser Create(IGherkinDialectProvider dialectProvider);
        IGherkinParser Create(CultureInfo cultureInfo);
    }
}
