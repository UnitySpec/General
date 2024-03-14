using System.Collections.Generic;

namespace UnitySpec.General.GeneratorInterfaces
{
    public interface IFeatureFileCodeBehindGenerator
    {
        IEnumerable<string> GenerateFilesForProject(IReadOnlyCollection<string> featureFiles, string projectFolder, string outputPath);

    }
}
