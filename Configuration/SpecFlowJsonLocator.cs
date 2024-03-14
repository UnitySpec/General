using System;
using System.IO;
using UnitySpec.General.Configuration.Interfaces;

namespace UnitySpec.General.Configuration
{
    public class SpecFlowJsonLocator : ISpecFlowJsonLocator
    {
        public const string JsonConfigurationFileName = "specflow.json";

        public string GetSpecFlowJsonFilePath()
        {
            var specflowJsonFileInAppDomainBaseDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, JsonConfigurationFileName);

            if (File.Exists(specflowJsonFileInAppDomainBaseDirectory))
            {
                return specflowJsonFileInAppDomainBaseDirectory;
            }

            var specflowJsonFileTwoDirectoriesUp = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", JsonConfigurationFileName);

            if (File.Exists(specflowJsonFileTwoDirectoriesUp))
            {
                return specflowJsonFileTwoDirectoriesUp;
            }

            var specflowJsonFileInCurrentDirectory = Path.Combine(Environment.CurrentDirectory, JsonConfigurationFileName);

            if (File.Exists(specflowJsonFileInCurrentDirectory))
            {
                return specflowJsonFileInCurrentDirectory;
            }

            return null;
        }
    }
}
