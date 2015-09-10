using System.Runtime.Serialization;

namespace MailChimp.DTOs
{
    /// <summary>
    /// Campaign Defaults - Default values for campaigns created for a list.
    /// https://us11.api.mailchimp.com/schema/3.0/Lists/Instance.json
    /// </summary>
    [DataContract]
    public class CampaignDefaults
    {
        [DataMember(Name = "from_name")]
        public string FromName { get; set; }

        [DataMember(Name = "from_email")]
        public string FromEmail { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "language")]
        public string Language { get; set; }
    }
}
