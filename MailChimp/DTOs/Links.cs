using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Resource Link - This object represents a link from the resource where it is found to another resource or action that may be performed.
    /// https://api.mailchimp.com/schema/3.0/Generics/ResourceLink.json
    /// </summary>
    [DataContract]
    public class ResourceLink
    {
        [DataMember(Name = "rel")]
        public string Rel { get; set; }

        [DataMember(Name = "href")]
        public string Href { get; set; }

        [DataMember(Name = "method")]
        public string Method { get; set; }

        [DataMember(Name = "targetSchema")]
        public string TargetSchema { get; set; }
    }
}
