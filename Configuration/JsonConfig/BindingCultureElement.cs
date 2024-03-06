using System.Runtime.Serialization;

namespace UnityFlow.SpecFlow.Configuration.JsonConfig
{
    public class BindingCultureElement
    {
        [DataMember(Name="name")]
        public string Name { get; set; }
    }
}