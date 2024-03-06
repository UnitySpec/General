using System;

namespace UnityFlow.General.Configuration
{
// ReSharper disable RedundantNameQualifier
    public static class ConfigDefaults
    {
        public const string FeatureLanguage = "en-US";
        public const string ToolLanguage = "";

        public const string UnitTestProviderName = "nunit";

        public const bool DetectAmbiguousMatches = true;
        public const bool StopAtFirstError = false;
        public const MissingOrPendingStepsOutcome MissingOrPendingStepsOutcome = UnityFlow.General.MissingOrPendingStepsOutcome.Pending;

        public const bool TraceSuccessfulSteps = true;
        public const bool TraceTimings = false;
        public const string MinTracedDuration = "0:0:0.1";
        public const StepDefinitionSkeletonStyle StepDefinitionSkeletonStyle = UnityFlow.General.StepDefinitionSkeletonStyle.RegexAttribute;
        public const ObsoleteBehavior ObsoleteBehavior = UnityFlow.General.ObsoleteBehavior.Warn;

        public const bool AllowDebugGeneratedFiles = false;
        public const bool AllowRowTests = true;
        public const string GeneratorPath = null;

        public static readonly string[] AddNonParallelizableMarkerForTags = Array.Empty<string>();
    }
// ReSharper restore RedundantNameQualifier
}