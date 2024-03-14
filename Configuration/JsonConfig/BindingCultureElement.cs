using System.Runtime.Serialization;

namespace UnitySpec.General.Configuration.JsonConfig
{
    public class BindingCultureElement
    {
        [DataMember(Name="name")]
        public string Name { get; set; }
    }
}