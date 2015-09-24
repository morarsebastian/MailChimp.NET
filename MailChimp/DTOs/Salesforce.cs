using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Salesforce CRM Tracking - Salesforce tracking options for a campaign.  Must be using MailChimp's built-in Salesforce integration.
    /// https://api.mailchimp.com/schema/3.0/Campaigns/Instance.json
    /// </summary>
    [DataContract]
    public class Salesforce
    {
        [DataMember(Name = "campaign")]
        public bool? Campaign { get; set; }

        [DataMember(Name = "notes")]
        public bool? Notes { get; set; }
    }
}
