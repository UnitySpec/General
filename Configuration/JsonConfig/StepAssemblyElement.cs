using System.Runtime.Serialization;

namespace UnitySpec.General.Configuration.JsonConfig
{
    public class StepAssemblyElement
    {
        //[JsonProperty("assembly", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(Name = "assembly")]
        public string Assembly { get; set; }
    }
}