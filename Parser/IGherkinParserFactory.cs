using Gherkin;
using System.Globalization;

namespace UnitySpec.General.Parser
{
    public interface IGherkinParserFactory
    {
        IGherkinParser Create(IGherkinDialectProvider dialectProvider);
        IGherkinParser Create(CultureInfo cultureInfo);
    }
}
