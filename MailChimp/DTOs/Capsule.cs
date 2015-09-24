using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Capsule CRM Tracking - Capsule tracking option sfor a campaign. Must be using MailChimp's built-in Capsule integration.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Capsule
    {
        [DataMember(Name = "notes")]
        public bool? Notes { get; set; }
    }
}
