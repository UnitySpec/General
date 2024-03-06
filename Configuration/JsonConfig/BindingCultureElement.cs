using System.Runtime.Serialization;

namespace UnityFlow.General.Configuration.JsonConfig
{
    public class BindingCultureElement
    {
        [DataMember(Name="name")]
        public string Name { get; set; }
    }
}