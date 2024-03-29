using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using UnitySpec.General.BindingSkeletons;

namespace UnitySpec.General.Configuration.JsonConfig
{
    public class TraceElement
    {
        //[JsonProperty("traceTimings", DefaultValueHandling = DefaultValueHandling.Populate, NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "traceTimings")]
        [DefaultValue(ConfigDefaults.TraceTimings)]
        public bool TraceTimings { get; set; }

        //[JsonProperty("minTracedDuration", DefaultValueHandling = DefaultValueHandling.Populate, NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "minTracedDuration")]
        [DefaultValue(ConfigDefaults.MinTracedDuration)]
        public TimeSpan MinTracedDuration { get; set; }

        //[JsonProperty("stepDefinitionSkeletonStyle", DefaultValueHandling = DefaultValueHandling.Populate, NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "stepDefinitionSkeletonStyle")]
        [DefaultValue(ConfigDefaults.StepDefinitionSkeletonStyle)]
        public StepDefinitionSkeletonStyle StepDefinitionSkeletonStyle { get; set; }

        //[JsonProperty("traceSuccessfulSteps", DefaultValueHandling = DefaultValueHandling.Populate, NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "traceSuccessfulSteps")]
        [DefaultValue(ConfigDefaults.TraceSuccessfulSteps)]
        public bool TraceSuccessfulSteps { get; set; }
    }
}