using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Highrise CRM Tracking - Highrise tracking options for a campaign. Must be using MailChimp's built-in Highrise integration.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Highrise
    {
        [DataMember(Name = "campaign")]
        public bool? Campaign { get; set; }

        [DataMember(Name = "notes")]
        public bool? Notes { get; set; }
    }
}
